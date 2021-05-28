using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace JouetGSB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void login_Click(object sender, EventArgs e)
        {
            string log = userlog.Text;
            string pass = userPass.Text;

            int I = CorrectYAdmin(log,pass);

            switch (I)
            {
                case 1:
                    // code block
                    break;
                case 2:
                    // code block
                    break;
                default:
                    // code block
                    break;
            }
        }

        public int CorrectYAdmin(string l,string p)
        {
            int value = 0;
            //Base de Donnée
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=jouetclub;";

            //Requete
            string query = "select * from employe where Login = @log and Password = @pass ";

            // Execution
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
           
            commandDatabase.Parameters.AddWithValue("@log", l);
            commandDatabase.Parameters.AddWithValue("@pass", p);
            databaseConnection.Open();


            using (MySqlDataReader reader = commandDatabase.ExecuteReader())
            {
                if (reader.Read())
                {
                    MessageBox.Show("yves");
                }
            }

            return value;
        }
    }
}
