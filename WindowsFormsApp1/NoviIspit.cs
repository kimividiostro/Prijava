using System;
using Oracle.DataAccess.Client;
using System.Windows.Forms;
using PrijavaIspitaKPA;

namespace WindowsFormsApp1
{
    public partial class NoviIspit : Form
    {
        OracleConnection connection;
        OracleCommand command;
        OracleDataReader reader;

        //POPUNI COMBOBOX SA PREDMETIMA IZ BAZE
        private void UcitajPredmete()
        {
            using (connection = new OracleConnection(Glavna.ConnectionString))
            {
                string query = "SELECT * FROM ana.predmeti";
                connection.Open();
                command = new OracleCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbPredmet.Items.Add(reader["nazivpredmeta"].ToString());
                }
            }
        }

        //DA LI SU POLJA POPUNJENA
        private bool IspravanUnos()
        {
            if (string.IsNullOrEmpty(tbSifra.Text) || string.IsNullOrEmpty(tbMesto.Text) || string.IsNullOrEmpty(cbPredmet.Text))
                return false;
            return true;
        }

        public NoviIspit()
        {
            InitializeComponent();
            UcitajPredmete();
        }


        private void bDodaj_Click(object sender, EventArgs e)
        {
            if (IspravanUnos())
            {
                try
                {
                    string id = tbSifra.Text;
                    string idPredmeta = "";
                    string mesto = tbMesto.Text;
                    DateTime date = new DateTime(year: datum.Value.Year, month: datum.Value.Month, day: datum.Value.Day,
                        hour: (vreme.Value.Hour + 1), minute: vreme.Value.Minute, second: 0);
                    using (connection = new OracleConnection(Glavna.ConnectionString))
                    {
                        string query = $"SELECT idpredmeta FROM ana.predmeti WHERE nazivpredmeta = '{cbPredmet.Text}'";
                        connection.Open();
                        command = new OracleCommand(query, connection);
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            idPredmeta = reader["idpredmeta"].ToString();
                        }
                        query = $"INSERT INTO ana.ispiti VALUES ('{id}','{idPredmeta}','{mesto}','{date.ToUniversalTime()}')";
                        command = new OracleCommand(query, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Uspešno upisano u bazu.", "Prijavljeno");
                    }
                }
                catch (OracleException)
                {
                    MessageBox.Show("Proverite da li šifra sadrži nedozvoljeni karakter, ili ispit sa istom šifrom već postoji.","Greška");
                }
            }
            else
            {
                MessageBox.Show("Proverite da li su podaci uneti ispravno.", "Neispravan unos");
            }
        }
    }
}
