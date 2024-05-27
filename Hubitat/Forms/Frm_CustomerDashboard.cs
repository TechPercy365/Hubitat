using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hubitat.Repositories;

namespace Hubitat.Forms
{
    public partial class Frm_CustomerDashboard : Form
    {
        public Frm_CustomerDashboard()
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
                txtWelcome.Text = "Welcome, Customer";
            }
        }

        private void x_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_buyPet_Click(object sender, EventArgs e)
        {
            var loggedInUser = UserLogged.GetInstance().User;
            if (loggedInUser != null)
            {
                Frm_C_BuyPets buyPetForm = new Frm_C_BuyPets(loggedInUser.userID, loggedInUser.firstName, loggedInUser.lastName, loggedInUser.email);
                buyPetForm.Show();
                this.Hide();
            }
        }
    }
}
