using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KickballSTL
{
    public partial class createSchedule : Form
    {
        public createSchedule()
        {
            InitializeComponent();
            comboBox1.Items.Add("Saint Charles");
            comboBox1.Items.Add("South County Sundays");
            comboBox1.Items.Add("South County Thursdays");
            comboBox1.Items.Add("South City");
            comboBox1.Items.Add("Wentzville");
            comboBox1.Items.Add("Valley Park");
            comboBox1.Items.Add("Swansea, Illinois");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string teamDivision;
            string divisionDate;


            monthCalendar1.MaxSelectionCount = 1;
            teamDivision = comboBox1.Text;
            divisionDate = monthCalendar1.SelectionRange.Start.ToShortDateString();
           


            // exception handler for empty fields    
          
            if (teamDivision == "")
            {
                MessageBox.Show("Please enter your division!");
            }
          

            else
            {
                MessageBox.Show("The following schedule has been created in the database:\r\n" +  "Division: " +
                    teamDivision + "\r\n" + "Start Date: " + divisionDate);
                this.Close();
            }
        }
    }
}
