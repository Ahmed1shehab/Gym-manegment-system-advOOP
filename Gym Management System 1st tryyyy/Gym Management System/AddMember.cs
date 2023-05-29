using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Gym_Management_System
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 450;
        }



        private void btnMHome_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }

        private void lblMExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMAdd_Click(object sender, EventArgs e)
        {
            if (txtMName.Text == "" || txtMPhone.Text == "" || txtMAge.Text == "" ||

                cmbMGender.Text == "" || cmbMPlan.Text == "" || cmbMTiming.Text == "")
            {

                MessageBox.Show(" Some information are missing! ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            MembersClass.InsertMember(txtMName.Text, txtMPhone.Text, Convert.ToInt32(txtMAge.Text), cmbMGender.Text,cmbMPlan.Text,Convert.ToInt32(cmbMTrainer.Text));

            MessageBox.Show("Member added Successfuly", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnMReset_Click(object sender, EventArgs e)
        {
            txtMAge.Text = "";
            txtMName.Text = "";
            txtMPhone.Text = "";
            cmbMTiming.Text = "Choose Timing";
            cmbMPlan.Text = "Choose Plan";
            cmbMGender.Text = "Choose Gender";
        }
    }
}
