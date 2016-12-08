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
    public partial class createSchedule : Form
    {
        public createSchedule()
        {
            InitializeComponent();
            
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
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source= C:\Users\Lee\Desktop\KickballSTL\kickballTeams.accdb"))
            {
                OleDbCommand command = new OleDbCommand("SELECT teamName FROM kickballTeams", connection);

                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    teamNameListBox.Items.Add(reader[0].ToString());
                }
                reader.Close();
            }
            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            String teamDivision1;
            String divisionDate;
            String teamSeason1;
            int fieldAmount;
            String gameTime;
            String teamName1 = null;
            String teamSeason2 = null;
            String teamDivision2 = null;
            String teamName2 = null;
            int id = 0;

            startDateCalendar.MaxSelectionCount = 1;
            teamDivision1 = divisionLocationComboBox.Text;
            divisionDate = startDateCalendar.SelectionRange.Start.ToShortDateString();
            teamSeason1 = seasonComboBox.Text;
            fieldAmount = 0;
            gameTime = dateTimePicker1.Text.ToString();
            
      

            // exception handler for empty fields    

            if (teamDivision1 == "")
            {
                MessageBox.Show("Please enter your division!");
            }
            else if (teamSeason1 == "")
            {
                MessageBox.Show("Please enter your season!");
            }

           




            else
            {
                MessageBox.Show("The following schedule has been created in the database:\r\n" + "Division: " +
                    teamDivision1 + "\r\n" + "Season: " + teamSeason1 + "\r\n" + "Start Date: " + divisionDate + "\r\n" + "First game's time: " + gameTime );
                this.Close();
            }


            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source= C:\Users\Lee\Desktop\KickballSTL\kickballTeams.accdb";

            try
            {
                conn.Open();



                String selectTeamName_KickballTeams = "select season, divisionLocation, teamName from kickballTeams";
                OleDbCommand cmd2 = new OleDbCommand(selectTeamName_KickballTeams, conn);

                OleDbDataReader reader = cmd2.ExecuteReader();

                //Keep track of the position index of each database field.
                int seasonOrdinal = reader.GetOrdinal("season");
                int teamDivisionOrdinal = reader.GetOrdinal("divisionLocation");
                int teamNameOrdinal = reader.GetOrdinal("teamName");
                //int i = 0;
              
                String my_query = null;
                OleDbCommand cmd = new OleDbCommand(my_query, conn);


          
               
                //string previousTeamName2 = null;
                
                //if (i <= fieldAmount) this would make the insert query loop until all kickball fields are holding two teams. 
                //{
            

                    while (reader.Read())
                    {

                        teamSeason1 = reader.GetString(seasonOrdinal);
                        teamDivision1 = reader.GetString(teamDivisionOrdinal);
                        teamName1 = reader.GetString(teamNameOrdinal);
                        //Hippos
                        reader.NextResult();
                        teamSeason2 = reader.GetString(seasonOrdinal);
                        //season = Winter
                        teamDivision2 = reader.GetString(teamDivisionOrdinal);
                        //teamDivision = South County Sundays

                        if (teamSeason1.Equals(teamSeason2) && teamDivision1.Equals(teamDivision2))
                        {
                            teamName2 = reader.GetString(teamNameOrdinal);
                            //Rhinos
                            reader.NextResult();



                        }
                        
                        my_query = "INSERT INTO fullSchedule(ID,season,divisionLocation,fieldNumber,gameTime,gameDate,teamName,teamName2)VALUES('" + id + "','" + teamSeason1 + "','" 
                        
                                  + teamDivision1 + "','" + fieldAmount  + "','" + gameTime + "','" +divisionDate+ "','" +teamName1+ "','" +teamName2+ "')";
                        cmd.ExecuteNonQuery();



                    }


                    reader.Close();




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
        //    i++;
        // if (i == fieldAmount)  //Once all fields are occupied, set new game time and continue through the loop all over again until all fields are utilized. 
        //  { 
        //    i = 0;
        //     gameTime = "12:00";      // new game time. 
        //    }
                //}


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This form allows you to create a schedule for the desired season, division, start date, and amount of fields." + "\r\n" + "\r\n" +
                "Select Season: Choose your desired season from the drop-down menu for the schedule you are creating." + "\r\n" + "\r\n" +
                "Select Division Location: Choose your desired division from the drop-down menu for the schedule you are creating." + "\r\n" + "\r\n" +
                "Select Season Start Date: Select the starting date of the desired schedule by selecting with your mouse." + "\r\n" + "\r\n"+
                "Number of Fields: Enter the number amount of fields to be played on for the current schedule." + "\r\n" + "Example: 4 NOT \"Four\"." + "\r\n" + "\r\n" +
                "After all fields have been filled, select the 'Generate Schedule' button to add the schedule to the database.");
            
        }

        private void createSchedule_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is for KickballSTL.");
        }

        private void teamNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


