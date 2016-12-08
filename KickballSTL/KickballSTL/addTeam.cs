using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KickballSTL
{
    public partial class addTeam : Form
    {
        public addTeam()
        {
            InitializeComponent();
            seasonComboBox.Items.Add("Winter");
            seasonComboBox.Items.Add("Spring");
            seasonComboBox.Items.Add("Summer");
            seasonComboBox.Items.Add("Fall");

            divisionComboBox.Items.Add("Saint Charles");
            divisionComboBox.Items.Add("South County Sundays");
            divisionComboBox.Items.Add("South County Thursdays");
            divisionComboBox.Items.Add("South City");
            divisionComboBox.Items.Add("Wentzville");
            divisionComboBox.Items.Add("Valley Park");
            divisionComboBox.Items.Add("Swansea, Illinois");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string teamDivision;
                string Season;
                string teamName;
               

                teamDivision = divisionComboBox.Text;
                teamName = teamNameTextBox.Text;
                Season = seasonComboBox.Text;
     

                // exception handler for empty fields    
                if (Season == "")
                {
                    MessageBox.Show("Please enter your season!");
                }
                else if (teamDivision == "")
                {
                    MessageBox.Show("Please enter your division!");
                }
                else if (teamName == "")
                {
                    MessageBox.Show("Please enter your team name!");
                }
              
                else
                {
                    MessageBox.Show("The following has been added to the database:\r\n"+ "Season: " + seasonComboBox.Text + "\r\n" + "Division: " + 
                        divisionComboBox.Text + "\r\n" +   "Team Name: " + teamNameTextBox.Text);
                    this.Close();
                }

                //this.tblCustomersBindingSource.AddNew();
                //this.tblCustomersBindingSource.EndEdit();
                //this.tblCustomersTableAdapter.Update(this.dataSet1.tblCustomers); // Updating the DB Table
            }

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
