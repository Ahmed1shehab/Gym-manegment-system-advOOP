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
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
            this.Width = 900;
            this.Height = 590;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtPAmount.Text == "" || cmbPName.SelectedItem == "")
            {

                MessageBox.Show(" Some information are missing! ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void btnPReset_Click(object sender, EventArgs e)
        {
            cmbPName.SelectedItem= "Select Member";
            txtPAmount.Text = "";
        }

        private void btnPBack_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void lblPExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
