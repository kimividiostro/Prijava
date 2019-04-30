using System;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using System.Windows.Forms;


namespace PrijavaIspitaKPA
{
    public partial class Student : Form
    {
        private struct Predmet
        {
            public Predmet(string ime, int id)
            {
                this.ime = ime;
                this.id = id;
            }
            public string ime;
            public int id;
        }
        List<Predmet> predmeti;
        int indeks;

        List<string> prijavljeniIspiti;

        OracleConnection connection;
        OracleCommand command;
        OracleDataReader reader;

        /*KONSTRUKTOR INICIJALIZUJE KOMPONENTE
                 * I POSTAVLJA LABELE SA PODACIMA STUDENTA*/
        public Student(string ime, string prezime, string brojIndeksa)
        {
            InitializeComponent();
            lIme.Text = ime;
            lPrezime.Text = prezime;
            lBrojIndeksa.Text = brojIndeksa;
            indeks = Convert.ToInt32(brojIndeksa);
            predmeti = new List<Predmet>();
            prijavljeniIspiti = new List<string>();
            UcitajPredmete();
            PopuniComboBox();
            UcitajTermine();
            UcitajPrijavljeneIspite();
        }

        private void UcitajPredmete()
        {
            using(connection = new OracleConnection(Glavna.ConnectionString))
            {
                string query = "SELECT * FROM ana.predmeti";
                connection.Open();
                command = new OracleCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    predmeti.Add(new Predmet(reader["nazivpredmeta"].ToString(), Convert.ToInt32(reader["idpredmeta"].ToString())));
                }
            }
        }

        private void PopuniComboBox()
        {
            foreach(Predmet predmet in predmeti)
            {
                cbPredmeti.Items.Add(predmet.ime);
            }
        }

        private void ResetujLabele()
        {
            lSifra.Text = "Šifra kursa: ";
            lNazivKursa.Text = "Naziv kursa: ";
            lProfesor.Text = "Profesor: ";
        }

        private void UcitajTermine()
        {
            using (connection = new OracleConnection(Glavna.ConnectionString))
            {
                string query = "SELECT ana.ispiti.idispita, ana.predmeti.nazivpredmeta, ana.ispiti.mesto, ana.ispiti.datumivreme FROM ana.ispiti INNER JOIN ana.predmeti ON ana.ispiti.idpredmeta = ana.predmeti.idpredmeta";
                connection.Open();
                command = new OracleCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string ispit = $"{reader[0].ToString()}, {reader[1].ToString()}, {reader[2].ToString()}, {reader[3].ToString()}";
                    lbTerminiIspita.Items.Add(ispit);
                }
            }
        }

        private void UcitajPrijavljeneIspite()
        {
            string query = $"SELECT ana.predmeti.nazivpredmeta, ana.prijavaispita.idispita FROM ana.predmeti INNER JOIN ana.prijavaispita ON ana.predmeti.idpredmeta = ana.prijavaispita.idispita WHERE ana.prijavaispita.brindeksa = {indeks}";
            using(connection = new OracleConnection(Glavna.ConnectionString))
            {
                connection.Open();
                command = new OracleCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listIspiti.Items.Add(reader[0].ToString());
                    prijavljeniIspiti.Add(reader[0].ToString());
                }
            }
        }


        /* NAKON STO SE IZABERE KURS IZ COMBOBOX
         * POPUNI LABELE SA INFORMACIJAMA O KURSU*/ 
        private void cbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            //UZMI IME IZABRANOG KURSA
            string kurs = cbPredmeti.SelectedItem.ToString();
            string query = $"SELECT * FROM ana.predmeti WHERE nazivpredmeta = '{kurs}'";
            using (connection = new OracleConnection(Glavna.ConnectionString))
            {
                connection.Open();
                command = new OracleCommand(query, connection);
                reader = command.ExecuteReader();
                ResetujLabele();
                while (reader.Read())
                { 
                    lSifra.Text += reader["idpredmeta"].ToString();
                    lNazivKursa.Text += reader["nazivpredmeta"].ToString();
                    lProfesor.Text += reader["profesor"].ToString();
                }
            }
        }


        private void bPrijaviIspit_Click(object sender, EventArgs e)
        {
            try
            {
                int comboboxIndex = cbPredmeti.SelectedIndex;
                string imePredmeta = predmeti[comboboxIndex].ime;
                foreach (string ispit in prijavljeniIspiti)
                {
                    if (ispit == imePredmeta)
                        throw new Exception("Izabrani ispit je već prijavljen.");
                }
                int idPredmeta = predmeti[comboboxIndex].id;
                string idPrijave = indeks.ToString() + idPredmeta.ToString();

                using(connection = new OracleConnection(Glavna.ConnectionString))
                {
                    string query = $"INSERT INTO ana.prijavaispita VALUES({idPrijave},{indeks},{idPredmeta})";
                    connection.Open();
                    command = new OracleCommand(query, connection);
                    command.ExecuteNonQuery();
                }
                listIspiti.Items.Clear();
                UcitajPrijavljeneIspite();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Niste izabrali ispit za prijavu.", "Greška");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška");
            }
        }
    }
}
