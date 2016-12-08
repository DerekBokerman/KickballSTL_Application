using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KickballSTL
{
    public partial class updateTeam : Form
    {

        public updateTeam()
        {
            InitializeComponent();
            cc();

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

              
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is for KickballSTL.");
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            //Edit Team Name, Season, Division. 
        }


        private void cc()

        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source= C:\Users\Lee\Desktop\KickballSTL\kickballTeams.accdb");
            divisionLocationComboBox.Items.Clear();
            seasonComboBox.Items.Clear();
            connection.Open();
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kickballTeams";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                divisionLocationComboBox.Items.Add(dr["Division"].ToString());
                seasonComboBox.Items.Add(dr["Season"].ToString());
            }
            connection.Close();

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source= C:\Users\Lee\Desktop\KickballSTL\kickballTeams.accdb");
            connection.Open();
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into kickballTeams values('"+textBox2.Text+ "','" + textBox3.Text + "','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();

            connection.Close();

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            cc();
            MessageBox.Show("You have inserted into the database.");
        }

        private void updateTeam_Load(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source= C:\Users\Lee\Desktop\KickballSTL\kickballTeams.accdb");
            connection.Open();
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kickballTeams where name='" + divisionLocationComboBox.SelectedItem.ToString() + "'";
            cmd.CommandText = "select * from kickballTeams where name='" + seasonComboBox.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)

            {
                textBox2.Text = dr["Season"].ToString();
                textBox3.Text = dr["Division"].ToString();
                textBox4.Text = dr["Team Name"].ToString();
            }
            connection.Close();
        }

        private void divisionLocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }

        
    }

