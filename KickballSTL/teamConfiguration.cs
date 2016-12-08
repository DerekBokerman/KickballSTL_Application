using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml.Serialization;

namespace KickballSTL
{
    public partial class teamConfiguration : Form
    {
        public static OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source= C:\Users\Lee\Desktop\KickballSTL\kickballTeams.accdb");
        public teamConfiguration()
        {
            InitializeComponent();
    


            
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source= C:\Users\Lee\Desktop\KickballSTL\kickballTeams.accdb"))
            {
                OleDbCommand command = new OleDbCommand("SELECT teamName FROM kickballTeams", connection);

                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    teamNameCheckedListBox.Items.Add(reader[0].ToString());
                }
                reader.Close();
            }
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source= C:\Users\Lee\Desktop\KickballSTL\kickballTeams.accdb"))
            {
                OleDbCommand command2 = new OleDbCommand("SELECT Season FROM Season", connection);

                connection.Open();
                OleDbDataReader reader = command2.ExecuteReader();

                while (reader.Read())
                {
                    seasonComboBox.Items.Add(reader[0].ToString());
                }
                reader.Close();
            }
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source= C:\Users\Lee\Desktop\KickballSTL\kickballTeams.accdb"))
            {
                OleDbCommand command3 = new OleDbCommand("SELECT division FROM divisionLocation", connection);

                connection.Open();
                OleDbDataReader reader = command3.ExecuteReader();

                while (reader.Read())
                {
                    divisionLocationComboBox.Items.Add(reader[0].ToString());
                }
                reader.Close();

                for (int i = 0; i < teamNameCheckedListBox.Items.Count; i++)
                {
                    teamNameCheckedListBox.SetItemChecked(i, true);
                }




            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is for KickballSTL.");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void teamConfiguration_Load(object sender, EventArgs e)
        {

        }

        private void Help_Click(object sender, EventArgs e)
        {

        }
    }
}
