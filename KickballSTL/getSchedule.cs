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
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace KickballSTL
{
    public partial class ScheduleForm : Form
    {
        public void GetSchedule()
        {
            InitializeComponent();
        

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
        

        public void button1_Click(object sender, EventArgs e)
        {
            string teamDivision;
            string teamName;
            string season;
            string fieldNumber;
            string gameTime = "";
            string gameDate;
            string ID;
            int yCoordPDF = 0;
            string teamName2;
            // int xCoordPDF = 0;
            int i = 0;
           // DateTimeConverter gt = new DateTimeConverter(gameTime);

            teamDivision = divisionLocationComboBox.Text;
            teamName = null;
            teamName = teamNameListBox.SelectedItem.ToString();
            season = seasonComboBox.Text;

            //MS Access SQL Initializer
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source= C:\Users\Lee\Desktop\KickballSTL\kickballTeams.accdb";

            String kickballTeamSQL = "SELECT * FROM fullSchedule WHERE teamName='"+ teamName +"'AND season='"+ season +"'AND division='"+teamDivision+"'";

            OleDbCommand comm = new OleDbCommand(kickballTeamSQL, conn);
            OleDbDataAdapter adpt = new OleDbDataAdapter(); //allows dataset, and therefore access database, to be altered.
            DataSet kickballSchedule = new DataSet(); // allows you to create a "local" database that makes data easier to alter in c#. kickballTeams table is pulled down to dataset.
            kickballSchedule.Clear();
           

           
            

            adpt.SelectCommand = comm; // calls the OleDbCommand variable comm and it's contents (the sql query and connection string) to be used in OleDbadapter variable adpt
            adpt.Fill(kickballSchedule); // alters dataset for kickball teams by filling kickballTeams' insides (by default the dataset is empty) with the database goodness from the OleDbCommand

           

            try
            {

                PdfDocument document = new PdfDocument();
                document.Info.Title = "KickballSTL Team Schedule";

                PdfPage page = document.AddPage();

                XGraphics gfx = XGraphics.FromPdfPage(page);

                XFont font = new XFont("Times New Roman", 12, XFontStyle.BoldItalic);

                yCoordPDF = 10;

                //gfx.DrawString(teamDivision, font, XBrushes.Black, new XRect(200, 100, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                //gfx.DrawString(season, font, XBrushes.Black, new XRect(360, 100, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                //gfx.DrawString(teamName, font, XBrushes.Black, new XRect(40, 100, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                gfx.DrawString("ID", font, XBrushes.Black, new XRect(40, yCoordPDF, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                gfx.DrawString("Team Name", font, XBrushes.Black, new XRect(120, yCoordPDF, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                gfx.DrawString("Season", font, XBrushes.Black, new XRect(200, yCoordPDF, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                gfx.DrawString("Division", font, XBrushes.Black, new XRect(280, yCoordPDF, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                gfx.DrawString("Game Date", font, XBrushes.Black, new XRect(360, yCoordPDF, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                gfx.DrawString("Opposing Team", font, XBrushes.Black, new XRect(440, yCoordPDF, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                gfx.DrawString("Field Number", font, XBrushes.Black, new XRect(520, yCoordPDF, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);


                //    gfx.DrawString("Field Number", font, XBrushes.Black, new XRect(440, yCoordPDF, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                //    gfx.DrawString("Game Date", font, XBrushes.Black, new XRect(480, yCoordPDF, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                //    gfx.DrawString("teamName2", font, XBrushes.Black, new XRect(440, yCoordPDF, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                //   gfx.DrawString("teamName", font, XBrushes.Black, new XRect(440, yCoordPDF, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                yCoordPDF = 75;


                for (i = 0; i <= kickballSchedule.Tables[0].Rows.Count - 1; i++)

                {
                   // DateTime Date;
                  //  DateTime.TryParseExact(gameDate, "mm/dd/yyyy",System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out Date);
                    //Date = Convert.ToString(gameDate);
                   // gameDate = Date.ToString();


                    ID = kickballSchedule.Tables[0].Rows[i].ItemArray[0].ToString();

                    teamName = kickballSchedule.Tables[0].Rows[i].ItemArray[1].ToString();

                    season = kickballSchedule.Tables[0].Rows[i].ItemArray[2].ToString();

                    teamDivision = kickballSchedule.Tables[0].Rows[i].ItemArray[3].ToString();

                    gameDate = kickballSchedule.Tables[0].Rows[i].ItemArray[4].ToString();

                    teamName2 = kickballSchedule.Tables[0].Rows[i].ItemArray[5].ToString();

                    fieldNumber = kickballSchedule.Tables[0].Rows[i].ItemArray[6].ToString();




                  //  fieldNumber = kickballSchedule.Tables[0].Rows[i].ItemArray[5].ToString();

                    // teamName2 = kickballSchedule.Tables[0].Rows[i].ItemArray[6].ToString();

                    //fieldNumber = kickballSchedule.Tables[0].Rows[i].ItemArray[8].ToString();

                    //gameTime = kickballSchedule.Tables[0].Rows[i].ItemArray[5].ToString();

                    //  gameDate = kickballSchedule.Tables[0].Rows[i].ItemArray[5].ToString();

                    // teamName2 = kickballSchedule.Tables[0].Rows[i].ItemArray[6].ToString();




                    gfx.DrawString(ID, font, XBrushes.Black, new XRect(40, yCoordPDF, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    gfx.DrawString(teamName, font, XBrushes.Black, new XRect(120, yCoordPDF, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                gfx.DrawString(season, font, XBrushes.Black, new XRect(200, yCoordPDF, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                gfx.DrawString(teamDivision, font, XBrushes.Black, new XRect(280, yCoordPDF, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                gfx.DrawString(gameDate, font, XBrushes.Black, new XRect(360, yCoordPDF, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                gfx.DrawString(teamName2, font, XBrushes.Black, new XRect(440, yCoordPDF, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    gfx.DrawString(fieldNumber, font, XBrushes.Black, new XRect(520, yCoordPDF, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    //  gfx.DrawString(fieldNumber, font, XBrushes.Black, new XRect(440, yCoordPDF, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    //  gfx.DrawString(gameDate, font, XBrushes.Black, new XRect(440, yCoordPDF, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);



                    yCoordPDF = yCoordPDF + 30;
                
                    if (yCoordPDF == 1000)
                    {

                    document.AddPage();

                    }
                    
                }


                string filename = ""+teamName+"'s Schedule.pdf";
                document.Save(filename); //not saving the location, just saving it as a filename.
  
                Process.Start(filename); //instantly opens PDF file


                if (teamDivision == "")
                {
                    MessageBox.Show("Please enter your division!");
                }
                else if (teamName == "")
                {
                    MessageBox.Show("Please select your team name!");
                }

                else
                {
                    MessageBox.Show("The following schedule is being generated :\r\n" + "Division: " + teamDivision + "\r\n" + "Team Name: " + teamName);
                    this.Close();
                }




            }

             catch(System.IO.IOException)
              {

                  MessageBox.Show("You have already created a team schedule. Please close or rename your existing file and try again.");

              }




           // kickballSchedule.Clear();

            conn.Close(); 




            // exception handler for empty fields    
           

           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This form allows you to view the schedule for the specified credentials. If you want to view the entire schedule for the season and division, simply leave the 'Select Team Name' field unselected." 
                + "\r\n" + "\r\n" +
                "Select Season: Choose your desired season from the drop-down menu for the schedule you are creating." + "\r\n" + "\r\n" +
                "Select Division Location: Choose your desired division from the drop-down menu for the schedule you are creating." + "\r\n" + "\r\n" + 
                "Select Team Name: Choose the team name from the list to view that team's schedule." + "\r\n" + "\r\n" + 
                "After all fields have been filled or selected, select the 'View Schedule' button to view the schedule.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is for KickballSTL.");
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {

        }

        private void teamNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
