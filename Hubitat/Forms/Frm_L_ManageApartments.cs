using Hubitat.Model;
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
    public partial class Frm_L_ManageApartments : Form
    {
        db_HubitatEntities db;

        public Frm_L_ManageApartments()
        {
            InitializeComponent();
            db = new db_HubitatEntities();
            loadApartment();
        }

        private void x_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            new Frm_LandlordDashboard().Show();
            this.Hide();
        }

        private void label_Home_Click(object sender, EventArgs e)
        {
            new Frm_LandlordDashboard().Show();
            this.Hide();
        }

        public void loadApartment()
        {
            dgv_Apartments.DataSource = db.vw_AllApartment.ToList();
        }

        private void btn_sortAll_Click(object sender, EventArgs e)
        {
            loadApartment();

            btn_sortAll.BackColor = Color.Black;
            btn_sortAll.ForeColor = Color.FromArgb(127, 228, 232);
            btn_sortOccupied.BackColor = Color.FromArgb(127, 228, 232);
            btn_sortOccupied.ForeColor = Color.Black;
            btn_sortVacant.BackColor = Color.FromArgb(127, 228, 232);
            btn_sortVacant.ForeColor = Color.Black;

            if (!(txt_apmtSearch.Text == "Search..." || String.IsNullOrEmpty(txt_apmtSearch.Text)))
            {
                SearchApartment();
            }
        }

        private void btn_sortVacant_Click(object sender, EventArgs e)
        {
            loadApartment();

            btn_sortAll.BackColor = Color.FromArgb(127, 228, 232);
            btn_sortAll.ForeColor = Color.Black;
            btn_sortOccupied.BackColor = Color.FromArgb(127, 228, 232);
            btn_sortOccupied.ForeColor = Color.Black;
            btn_sortVacant.BackColor = Color.Black;
            btn_sortVacant.ForeColor = Color.FromArgb(127, 228, 232);

            if (!(txt_apmtSearch.Text == "Search..." || String.IsNullOrEmpty(txt_apmtSearch.Text)))
            {
                SearchApartment();
            }
        }

        private void btn_sortOccupied_Click(object sender, EventArgs e)
        {
            loadApartment();

            btn_sortAll.BackColor = Color.FromArgb(127, 228, 232);
            btn_sortAll.ForeColor = Color.Black;
            btn_sortOccupied.BackColor = Color.Black;
            btn_sortOccupied.ForeColor = Color.FromArgb(127, 228, 232);
            btn_sortVacant.BackColor = Color.FromArgb(127, 228, 232);
            btn_sortVacant.ForeColor = Color.Black;

            if (!(txt_apmtSearch.Text == "Search..." || String.IsNullOrEmpty(txt_apmtSearch.Text)))
            {
                SearchApartment();
            }
        }

        public void SearchApartment()
        {
            string title = txt_apmtSearch.Text.Trim();

            if (btn_sortAll.BackColor == Color.Black)
            {
                this.dgv_Apartments.DataSource = db.vw_AllApartment.Where(x => x.Apartment_ID.Contains(title)).OrderBy(x => x.Apartment_ID).ToList();
            }
            else if (btn_sortOccupied.BackColor == Color.Black)
            {
                this.dgv_Apartments.DataSource = db.VW_OccupiedApmt.Where(x => x.Apartment_ID.Contains(title)).OrderBy(x => x.Apartment_ID).ToList();
            }
            else if (btn_sortVacant.BackColor == Color.Black)
            {
                this.dgv_Apartments.DataSource = db.vw_VacantApmt.Where(x => x.Apartment_ID.Contains(title)).OrderBy(x => x.Apartment_ID).ToList();
            }
        }
        private void pic_AddApmt_Click(object sender, EventArgs e)
        {

        }

        private void pic_addApmtImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if(openfile.ShowDialog() == DialogResult.OK)
            {
                pic_Apmt.Image = new Bitmap(openfile.FileName);
            }
            else
            {
                MessageBox.Show("Error: Cannot add Image. Pleae Try Again.");
            }
        }
    }
}
