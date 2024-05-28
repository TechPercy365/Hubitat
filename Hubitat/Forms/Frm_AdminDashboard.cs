using Hubitat.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hubitat.Forms
{
    public partial class Frm_AdminDashboard : Form
    {
        public Frm_AdminDashboard()
        {
            InitializeComponent();
            LoadWelcomeMessage();
        }

        private void LoadWelcomeMessage()
        {
            // Access the logged-in user's details
            var loggedInUser = UserLogged.GetInstance().User;

            if (loggedInUser != null)
            {
                // Set the welcome message with the username
                txtWelcome.Text = $"Welcome, {loggedInUser.userName}";
            }
            else
            {
                txtWelcome.Text = "Welcome, Employee";
            }
        }

        private void x_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_manUsers_Click(object sender, EventArgs e)
        {
            new Frm_A_ManageUsers().Show();
            this.Hide();
        }

        private void btn_manPets_Click(object sender, EventArgs e)
        {
            new Frm_ManagePets().Show();
            this.Hide();
        }

        private void pic_Reports_Click(object sender, EventArgs e)
        {
            new Frm_Reports().Show();
            this.Hide();
        }

        private void pic_Logout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirm: Are you sure you want to log-out?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirm == DialogResult.OK)
            {
                new Frm_Login().Show();
                this.Hide();
            }
        }
    }
}
