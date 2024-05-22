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
using System.IO;
using Hubitat.Repositories;

namespace Hubitat.Forms
{
    public partial class Frm_A_ManagePets : Form
    {
        hubitatDBEntities db;
        PetRepository apRepo;
        private String imgStr;

        public Frm_A_ManagePets()
        {
            InitializeComponent();
            db = new hubitatDBEntities();
            apRepo = new PetRepository();
            loadApartment();
        }

        private void x_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            new Frm_AdminDashboard().Show();
            this.Hide();
        }

        private void label_Home_Click(object sender, EventArgs e)
        {
            new Frm_AdminDashboard().Show();
            this.Hide();
        }

        public void loadApartment()
        {
            dgv_Apartments.DataSource = db.vw_AllPets.ToList();
        }

        private void btn_sortAll_Click(object sender, EventArgs e)
        {
            //loadApartment();

            //btn_sortAll.BackColor = Color.Black;
            //btn_sortAll.ForeColor = Color.FromArgb(127, 228, 232);
            //btn_sortOccupied.BackColor = Color.FromArgb(127, 228, 232);
            //btn_sortOccupied.ForeColor = Color.Black;
            //btn_sortVacant.BackColor = Color.FromArgb(127, 228, 232);
            //btn_sortVacant.ForeColor = Color.Black;

            //if (!(txt_apmtSearch.Text == "Search..." || String.IsNullOrEmpty(txt_apmtSearch.Text)))
            //{
            //    SearchApartment();
            //}
        }

        private void btn_sortVacant_Click(object sender, EventArgs e)
        {
            //loadApartment();

            //btn_sortAll.BackColor = Color.FromArgb(127, 228, 232);
            //btn_sortAll.ForeColor = Color.Black;
            //btn_Available.BackColor = Color.FromArgb(127, 228, 232);
            //btn_Available.ForeColor = Color.Black;
            //btn_Sold.BackColor = Color.Black;
            //btn_Sold.ForeColor = Color.FromArgb(127, 228, 232);

            //if (!(txt_apmtSearch.Text == "Search..." || String.IsNullOrEmpty(txt_apmtSearch.Text)))
            //{
            //    SearchApartment();
            //}
        }

        private void btn_sortOccupied_Click(object sender, EventArgs e)
        {
            //loadApartment();

            //btn_sortAll.BackColor = Color.FromArgb(127, 228, 232);
            //btn_sortAll.ForeColor = Color.Black;
            //btn_Available.BackColor = Color.Black;
            //btn_Available.ForeColor = Color.FromArgb(127, 228, 232);
            //btn_Sold.BackColor = Color.FromArgb(127, 228, 232);
            //btn_Sold.ForeColor = Color.Black;

            //if (!(txt_apmtSearch.Text == "Search..." || String.IsNullOrEmpty(txt_apmtSearch.Text)))
            //{
            //    SearchApartment();
            //}
        }

        public void SearchApartment()
        {
            //string title = txt_apmtSearch.Text.Trim();

            //if (btn_sortAll.BackColor == Color.Black)
            //{
            //    this.dgv_Apartments.DataSource = db.vw_AllApartment.Where(x => x.Apartment_ID.Contains(title)).OrderBy(x => x.Apartment_ID).ToList();
            //}
            //else if (btn_Available.BackColor == Color.Black)
            //{
            //    this.dgv_Apartments.DataSource = db.VW_OccupiedApmt.Where(x => x.Apartment_ID.Contains(title)).OrderBy(x => x.Apartment_ID).ToList();
            //}
            //else if (btn_Sold.BackColor == Color.Black)
            //{
            //    this.dgv_Apartments.DataSource = db.vw_VacantApmt.Where(x => x.Apartment_ID.Contains(title)).OrderBy(x => x.Apartment_ID).ToList();
            //}
        }
        private void pic_AddApmt_Click(object sender, EventArgs e)
        {            

            //if(String.IsNullOrEmpty(txt_apmtPrice.Text) || String.IsNullOrEmpty(cmbStatus.Text))
            //{
            //    MessageBox.Show("Please Enter the Price and the Status of the Apartment before adding it.");
            //    return;
            //}

            //if(pic_Apmt.Image != null)
            //{
            //    using (MemoryStream ms = new MemoryStream())
            //    {
            //        pic_Apmt.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //        byte[] aImage = ms.ToArray();
            //        imgStr = Convert.ToBase64String(aImage);
            //    }
            //} 
            ////String desc = txt_apmtDesc.Text;
            //decimal price = decimal.Parse(txt_apmtPrice.Text);
            ////String type = txt_apmtType.Text;
            //String status = cmbStatus.SelectedItem.ToString();

            //apRepo.AddApartment(txt_apmtDesc.Text, price, txt_apmtType.Text, status, imgStr);
            //loadApartment();
            
        }

        private void pic_addApmtImg_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openfile = new OpenFileDialog();
            //if(openfile.ShowDialog() == DialogResult.OK)
            //{
            //    pic_Apmt.Image = new Bitmap(openfile.FileName);
            //}
            //else
            //{
            //    MessageBox.Show("Error: Cannot add Image. Pleae Try Again.");
            //}
        }

        
    }
}
