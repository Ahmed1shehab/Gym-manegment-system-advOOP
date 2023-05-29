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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Width = 950;
            this.Height = 600;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMember s = new AddMember();
            s.Show();
            this.Hide();
        }

        private void btnViewMember_Click(object sender, EventArgs e)
        {
            ViewMembers viewMembers = new ViewMembers();
            viewMembers.Show();
            this.Hide();
        }

        private void btnUpdateDelete_Click(object sender, EventArgs e)
        {
            UpdateDelete delete = new UpdateDelete();
            delete.Show();
            this.Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payments payment = new Payments();
            payment.Show();
            this.Hide();
        }

        private void btnTrainers_Click(object sender, EventArgs e)
        {
            Trainers trainers = new Trainers();
            trainers.Show();
            this.Hide();
        }

        private void lblMainExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
