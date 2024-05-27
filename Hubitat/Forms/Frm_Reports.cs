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
    public partial class Frm_Reports : Form
    {
        public Frm_Reports()
        {
            InitializeComponent();
        }

        private void x_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_Home_Click(object sender, EventArgs e)
        {
            new Frm_AdminDashboard().Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            new Frm_AdminDashboard().Show();
            this.Hide();
        }
    }
}
