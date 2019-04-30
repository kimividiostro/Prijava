using System;
using System.Windows.Forms;
using WindowsFormsApp1;
using Oracle.DataAccess.Client;
using System.Collections.Generic;
using Oracle.DataAccess.Types;

namespace PrijavaIspitaKPA
{
    public partial class Admin : Form
    {
        OracleConnection connection;
        OracleCommand command;
        OracleDataReader reader;

        List<int> indeksi;

        //POPUNI LISTU SA ZAKAZANIM ISPITIMA
        private void UcitajIspite()
        {
            using(connection = new OracleConnection(Glavna.ConnectionString))
            {
                string query = "SELECT ana.ispiti.idispita, ana.predmeti.nazivpredmeta, ana.ispiti.mesto, ana.ispiti.datumivreme FROM ana.ispiti INNER JOIN ana.predmeti ON ana.ispiti.idpredmeta = ana.predmeti.idpredmeta";
                connection.Open();
                command = new OracleCommand(query, connection);
                reader = command.ExecuteReader();
                string date = "";
                string min = "";
                while (reader.Read())
                {
                    date = reader[3].ToString();
                    OracleTimeStamp ts = new OracleTimeStamp(date);
                    if (ts.Minute < 10)
                        min = $"{ts.Minute}0";
                    else
                        min = ts.Minute.ToString();
                    string displayDate = $"{ts.Day}.{ts.Month}.{ts.Year}, {ts.Hour}:{min}";
                    string ispit = $"{reader[0]}, {reader[1]}, {reader[2]}, {displayDate}";
                    listIspiti.Items.Add(ispit);
                }
            }
        }

        //POPUNI COMBOBOX SA REGISTROVANIM STUDENTIMA
        private void UcitajStudente()
        {
            string query = "SELECT ime, prezime, brindeksa FROM ana.korisnici WHERE NOT admin = 1";
            using(connection = new OracleConnection(Glavna.ConnectionString))
            {
                connection.Open();
                command = new OracleCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string student = "";
                    student += $"{reader[2]}, {reader[0]} {reader[1]}";
                    cbStudenti.Items.Add(student);
                    indeksi.Add(Convert.ToInt32(reader[2].ToString()));
                }
            }
        }

        public Admin()
        {
            InitializeComponent();
            indeksi = new List<int>();
            UcitajIspite();
            UcitajStudente();
        }

        //OTVARA PROZOR ZA ZAKAZIVANJE ISPITA
        private void bDodajIspit_Click(object sender, EventArgs e)
        {
            NoviIspit n = new NoviIspit();
            this.Hide();
            n.Show();
            n.FormClosed += N_FormClosed;
        }


        //DOGADJAJ KOJI UCITAVA ISPITE NAKON STO SE ZATVORI
        //FORMA ZA KREIRANJE NOVOG ISPITA
        private void N_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.listIspiti.Items.Clear();
            this.UcitajIspite();
            this.Show();
        }


        //DOGADJAJ KOJI ISPISUJE ISPITE KOJE JE IZABRANI STUDENT PRIJAVIO
        private void cbStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            int comboIndex = cbStudenti.SelectedIndex;
            int index = indeksi[comboIndex];
            string query = $"SELECT ana.predmeti.nazivpredmeta FROM ana.predmeti INNER JOIN ana.prijavaispita ON ana.predmeti.idpredmeta = ana.prijavaispita.idispita WHERE ana.prijavaispita.brindeksa = {index}";
            using(connection = new OracleConnection(Glavna.ConnectionString))
            {
                connection.Open();
                command = new OracleCommand(query, connection);
                reader = command.ExecuteReader();
                listPrijavljeniIspiti.Items.Clear();
                while (reader.Read())
                {
                    listPrijavljeniIspiti.Items.Add(reader[0]);
                }
            }
        }
    }
}
