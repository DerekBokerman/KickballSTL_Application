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
    public partial class topMenu : Form
    {
        public topMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addTeam add = new addTeam();
            add.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            createSchedule create = new createSchedule();
            create.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ScheduleForm get = new ScheduleForm();
            //get.ShowDialog();
            get.Show();
            get.GetSchedule();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This form allows you to choose from the other available forms." + "\r\n" + "\r\n" +
                "Using the mouse, click on the desired action with the corresponding button." + "\r\n" + "\r\n" +
                "Add Team: This will bring you to a form where you can add teams to the database for schedule creation."+ "\r\n" + "\r\n" + 
                "Create Schedule: This will bring you to a form where you can create a schedule." + "\r\n" + "\r\n" + 
                "View Schedule: This will bring you to a form where you can view an already created schedule." + "\r\n" + "\r\n" + 
                "Exit: Closes the application. You will have to start the application again to use it after selecting 'Exit'. ");
           
        }

        private void topMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is for KickballSTL.");
        }

        private void teamConfigurationButton_Click(object sender, EventArgs e)
        {
            teamConfiguration create = new teamConfiguration();
            create.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            updateTeam create = new updateTeam();
            create.ShowDialog();
        }
    }
 }

