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
    public partial class Trainers : Form
    {
        public Trainers()
        {
            InitializeComponent();
            this.Width = 750;
        }

        private void btnTAdd_Click(object sender, EventArgs e)
        {
            if (txtTName.Text == "" ||txtTPhone.Text == "" || txtTSalary.Text == "" || txtTAge.Text == "")
            {

                MessageBox.Show(" Some information are missing! ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            TrainersClass.InsertTrainer(txtTName.Text, txtTPhone.Text, Convert.ToInt32(txtTAge.Text),Convert.ToInt32(txtTSalary.Text));

            MessageBox.Show("New trainer is hired Successfuly", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTReset_Click(object sender, EventArgs e)
        {
            txtTName.Text = "";
            txtTPhone.Text = "";
            txtTSalary.Text = "";
            txtTAge.Text = "";
        }

        private void btnTHome_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }

        private void lblTExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
