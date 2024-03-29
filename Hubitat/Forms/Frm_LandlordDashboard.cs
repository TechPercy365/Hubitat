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
    public partial class Frm_LandlordDashboard : Form
    {
        public Frm_LandlordDashboard()
        {
            InitializeComponent();
        }

        private void x_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_manUsers_Click(object sender, EventArgs e)
        {
            new Frm_L_ManageUsers().Show();
            this.Hide();
        }

        private void btn_manApartments_Click(object sender, EventArgs e)
        {
            new Frm_L_ManageApartments().Show();
            this.Hide();
        }
    }
}
