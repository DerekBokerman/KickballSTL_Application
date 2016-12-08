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

namespace KickballSTL
{
    public partial class addTeam : Form
    {
        public addTeam()
        {
            InitializeComponent();

                       
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

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string teamDivision;
                string teamName;
               

                teamDivision = divisionLocationComboBox.Text.ToString();
                teamName = teamNameTextBox.Text.ToString();
                


                // exception handler for empty fields    
                if (teamDivision == "")
                {
                    MessageBox.Show("Please enter your division!");
                }
                else if (teamName == "")
                {
                    MessageBox.Show("Please enter your team name!");
                }
              
                else
                {
                    MessageBox.Show("The following has been added to the database:\r\n"+ "Season: " +  "\r\n" + "Division: " + 
                        divisionLocationComboBox.Text + "\r\n" +   "Team Name: " + teamNameTextBox.Text);
                    this.Close();
                }



                System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source= C:\Users\Lee\Desktop\KickballSTL\kickballTeams.accdb";

                try
                {
                    conn.Open();
                   
                    String my_query = "INSERT INTO kickballTeams(division,teamName)VALUES('" + teamDivision + "','" + teamName + "')";
             


                    OleDbCommand cmd = new OleDbCommand(my_query, conn);
                   

                    cmd.ExecuteNonQuery();
                  

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed due to" + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addTeam_Load(object sender, EventArgs e)
        {

        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This form allows you to add teams to the database." + "\r\n" + "\r\n" +
                "Select Season: Choose your desired season from the drop-down menu for the team you are adding." + "\r\n" + "\r\n" +
                "Select Division Location: Choose your desired division from the drop-down menu for the team you are adding." + "\r\n" + "\r\n" +
                "Enter Desired Team Name: Enter the name of the team that you are adding to the database." + "\r\n" + "\r\n" +
                "After all fields have been filled, selecting the 'Add Team' button will add the team to the database."


                );
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is for KickballSTL.");
        }
    }
}
