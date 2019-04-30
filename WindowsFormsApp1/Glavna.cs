using System;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace PrijavaIspitaKPA
{
    public partial class Glavna : Form
    {
        //Connection string i njegov property
        #region connection string i prop
        private static string connectionString = "Data source = (DESCRIPTION = (ADDRESS_LIST =(ADDRESS = (PROTOCOL = IPC)(KEY = EXTPROC1)))" +
        "(CONNECT_DATA =(SID = xe)(PRESENTATION = RO)));User Id = system; Password = 123;";

        public static string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }
        #endregion

        public Glavna()
        {
            InitializeComponent();
        }

        //BRISE TEKST IZ POLJA ZA UNOS
        private void ResetujPolja()
        {
            this.tbKorisnickoIme.Text = "";
            this.tbLozinka.Text = "";
        }


        #region Dogadjaji zatvaranja formi

        /*DOGADJAJ KOJI PRIKAZUJE POCETNU FORMU
        NAKON STO SE ZATVORI FORMA STUDENT*/
        private void Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        /*DOGADJAJ KOJI PRIKAZUJE POCETNU FORMU
         * NAKON STO SE ZATVORI FORMA GOST*/
        private void Gost_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        /*DOGADJAJ KOJI PRIKAZUJE POCETNU FORMU
         * NAKON STO SE ZATVORI FORMA ZA REGISTRACIJU*/
        private void Registracija_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        #endregion



        //DOGADJAJ DUGMETA ZA PRIJAVU
        private void bPrijaviSe_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";

            //PROVERI DA LI SU PRAZNA POLJA
            if (!string.IsNullOrEmpty(tbKorisnickoIme.Text.Trim()) && !string.IsNullOrEmpty(tbLozinka.Text.Trim()))
            {
                username = tbKorisnickoIme.Text;
                password = tbLozinka.Text;
                OracleDataReader reader;
                try
                {
                    using (OracleConnection connection = new OracleConnection(connectionString))
                    {
                        //POKUSAJ DA PROSLEDIS UPIT
                        string query = $"SELECT * FROM ana.korisnici WHERE korisnickoime = '{username}' AND lozinka = '{password}'";
                        connection.Open();
                        OracleCommand command = new OracleCommand(query, connection);
                        reader = command.ExecuteReader();
                        reader.Read();
                        //AKO NEMA ZAPISA, KORISNIK NE POSTOJI
                        if (reader.HasRows)
                        {
                            //PROVERI DA LI KORISNIK IMA STATUS ADMINA 
                            if (reader["admin"].ToString() == "1")
                            {
                                Admin admin = new Admin();
                                ResetujPolja();
                                this.Hide();
                                admin.Show();
                                admin.FormClosed += Admin_FormClosed;
                            }
                            else
                            {
                                //NEMA STATUS ADMINA, STUDENT JE
                                string ime = reader["ime"].ToString();
                                string prezime = reader["prezime"].ToString();
                                string indeks = reader["brindeksa"].ToString();
                                Student student = new Student(ime, prezime, indeks);
                                student.FormClosed += Student_FormClosed;
                                ResetujPolja();
                                this.Hide();
                                student.ShowDialog();
                            }
                        }
                        else
                            MessageBox.Show("Korisnik sa navedenim podacima ne postoji.", "Greška");
                        reader.Close();
                    }
                }
                catch(OracleException)
                {
                    MessageBox.Show("Greška pri povezivanju sa bazom.", "Greška");
                }
            }
            else
                MessageBox.Show("Polja za korisničko ime i lozniku ne smeju biti prazna.", "Greška");
        }



        //DOGADJAJ LINKA ZA PRIJAVU KAO GOST
        private void linkGost_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gost gost = new Gost();
            ResetujPolja();
            this.Hide();
            gost.Show();
            gost.FormClosed += Gost_FormClosed;
        }



        //DOGADJAJ LINKA ZA REGISTRACIJU
        private void linkRegistruj_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.FormClosed += Registracija_FormClosed;
            ResetujPolja();
            this.Hide();
            registracija.Show();
        }
    }
}
