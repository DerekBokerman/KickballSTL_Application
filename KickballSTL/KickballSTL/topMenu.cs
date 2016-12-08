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
            getSchedule get = new getSchedule();
            get.ShowDialog();
        }
    }
}
