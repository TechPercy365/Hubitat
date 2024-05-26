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
    }
}
