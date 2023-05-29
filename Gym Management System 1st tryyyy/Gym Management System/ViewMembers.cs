using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class ViewMembers : Form
    {
        public ViewMembers()
        {
            InitializeComponent();
            this.Width = 850;
            this.Height= 530;
        }

        private void btnVMHome_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }
        private void populate()
        {









        }

        private void lblVMExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
