using Oracle.DataAccess.Client;
using System.Windows.Forms;
using System;

namespace PrijavaIspitaKPA
{
    public partial class Registracija : Form
    {
        OracleConnection connection;
        OracleCommand command;

        //PROVERAVA DA LI SU POPUNJENA SVA POLJA
        private void ProveriUnetePodatke()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        throw new Exception("Niste popunili sva polja.");
                    }
                }
            }
        }

        //BRISE MOGUCE RAZMAKE IZ POLJA
        private void TrimujUnos()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    textBox.Text.Trim();
                }
            }
        }

        //PROVERAVA DA LI SE PODUDARAJU UNETE LOZINKE
        private void ProveriJednakostLozinki()
        {
            string loz1 = tbLozinka.Text;
            string loz2 = tbLozinkaPot.Text;
            if (loz1 != loz2)
                throw new Exception("Unete lozinke nisu iste.");
        }

        public Registracija()
        {
            InitializeComponent();
        }

        private void bRegistrujSe_Click(object sender, EventArgs e)
        {
            try
            {
                ProveriUnetePodatke();
                int indeks = int.Parse(tbBrojIndeksa.Text);
                ProveriJednakostLozinki();
                TrimujUnos();
                string ime = tbIme.Text;
                string prezime = tbPrezime.Text;
                string korisnickoIme = tbKorisnickoIme.Text;
                string lozinka = tbLozinka.Text;
                using(connection = new OracleConnection(Glavna.ConnectionString))
                {
                    string query = $"INSERT INTO ana.korisnici VALUES('{indeks}','{ime}','{prezime}','{korisnickoIme}','{lozinka}','0')";
                    connection.Open();
                    command = new OracleCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspešno ste se registrovali!", "Registrovano");
                }
            }
            catch (OracleException)
            {
                MessageBox.Show("Korisnik sa unetim korisničkim imenom ili brojem indeksa već postoji", "Greška");
            }
            catch(FormatException)
            {
                MessageBox.Show("Broj indeksa ne sme sadržati ništa sem brojeva.", "Greška");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška");
            }
        }
    }
}
