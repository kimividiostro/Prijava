using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace PrijavaIspitaKPA
{
    public partial class Gost : Form
    {
        OracleConnection connection;
        OracleCommand command;
        OracleDataReader reader;

        //POPUNI LISTU SA ZAKAZANIM ISPITIMA
        private void UcitajIspite()
        {
            using (connection = new OracleConnection(Glavna.ConnectionString))
            {
                string query = "SELECT ana.ispiti.idispita, ana.predmeti.nazivpredmeta, ana.ispiti.mesto, ana.ispiti.datumivreme FROM ana.ispiti INNER JOIN ana.predmeti ON ana.ispiti.idpredmeta = ana.predmeti.idpredmeta";
                connection.Open();
                command = new OracleCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string ispit = $"{reader[1].ToString()}, {reader[2].ToString()}, {reader[3].ToString()}";
                    listIspiti.Items.Add(ispit);
                }
            }
        }

        public Gost()
        {
            InitializeComponent();
            UcitajIspite();
        }
    }
}
