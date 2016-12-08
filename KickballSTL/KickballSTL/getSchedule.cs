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
    public partial class getSchedule : Form
    {
        public getSchedule()
        {
            InitializeComponent();
            comboBox1.Items.Add("Saint Charles");
            comboBox1.Items.Add("South County Sundays");
            comboBox1.Items.Add("South County Thursdays");
            comboBox1.Items.Add("South City");
            comboBox1.Items.Add("Wentzville");
            comboBox1.Items.Add("Valley Park");
            comboBox1.Items.Add("Swansea, Illinois");

            comboBox2.Items.Add("Romping Rhinos");
            comboBox2.Items.Add("Jaguars");
            comboBox2.Items.Add("Pandas");
            comboBox2.Items.Add("Monkeys");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string teamDivision;
            string teamName;
           

            teamDivision = comboBox1.Text;
            teamName = comboBox2.Text;


            // exception handler for empty fields    
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
