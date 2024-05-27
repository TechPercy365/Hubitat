using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Hubitat.Repositories;
using System.Drawing.Drawing2D;
using System.Xml.Linq;
using Hubitat.Model;

namespace Hubitat.Forms
{
    public partial class Frm_A_ManagePets : Form
    {
        hubitatDBEntities db;
        PetRepository petRepo;
        private byte[] pImage;
        private string deletepet;
        private string tempPetID;

        public Frm_A_ManagePets()
        {
            InitializeComponent();
            db = new hubitatDBEntities();
            petRepo = new PetRepository();
            loadPets();
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

        public void loadPets()
        {
            dg_Pets.DataSource = db.vw_AllPets.ToList();
        }

        private void btn_sortAll_Click(object sender, EventArgs e)
        {
            loadPets();

            btn_sortAll.BackColor = Color.Black;
            btn_sortAll.ForeColor = Color.FromArgb(127, 228, 232);
            btn_Available.BackColor = Color.FromArgb(127, 228, 232);
            btn_Available.ForeColor = Color.Black;
            btn_Sold.BackColor = Color.FromArgb(127, 228, 232);
            btn_Sold.ForeColor = Color.Black;

            if (!(txt_petSearch.Text == "Search..." || String.IsNullOrEmpty(txt_petSearch.Text)))
            {
                SearchPet();
            }
        }        

        public void SearchPet()
        {
            string title = txt_petSearch.Text.Trim();

            if (btn_sortAll.BackColor == Color.Black)
            {
                loadPets();
            }
            else if (btn_Available.BackColor == Color.Black)
            {
                this.dg_Pets.DataSource = db.vw_PetAvailable.OrderBy(p => p.Pet_Status).ToList();
            }
            else if (btn_Sold.BackColor == Color.Black)
            {
                this.dg_Pets.DataSource = db.vw_PetSold.OrderBy(p => p.Pet_Status).ToList();
            }
        }   

        private void btn_Available_Click(object sender, EventArgs e)
        {
            loadPets();

            btn_sortAll.BackColor = Color.FromArgb(127, 228, 232);
            btn_sortAll.ForeColor = Color.Black;
            btn_Available.BackColor = Color.Black;
            btn_Available.ForeColor = Color.FromArgb(127, 228, 232);
            btn_Sold.BackColor = Color.FromArgb(127, 228, 232);
            btn_Sold.ForeColor = Color.Black;

            if (!(txt_petSearch.Text == "Search..." || String.IsNullOrEmpty(txt_petSearch.Text)))
            {
                SearchPet();
            }
        }
       
        private void btn_Sold_Click_1(object sender, EventArgs e)
        {
            loadPets();

            btn_sortAll.BackColor = Color.FromArgb(127, 228, 232);
            btn_sortAll.ForeColor = Color.Black;
            btn_Available.BackColor = Color.FromArgb(127, 228, 232);
            btn_Available.ForeColor = Color.Black;
            btn_Sold.BackColor = Color.Black;
            btn_Sold.ForeColor = Color.FromArgb(127, 228, 232);

            if (!(txt_petSearch.Text == "Search..." || String.IsNullOrEmpty(txt_petSearch.Text)))
            {
                SearchPet();
            }
        }

        private void pic_addPetImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                pic_Pet.Image = new Bitmap(openfile.FileName);
            }
            else
            {
                MessageBox.Show("Error: Cannot add Image. Pleae Try Again.");
            }
        }

        private void pic_AddPet_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Price.Text) || String.IsNullOrEmpty(cmb_Status.Text))
            {
                MessageBox.Show("Please Enter the Price and the Status of the Apartment before adding it.");
                return;
            }

            if (pic_Pet.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pic_Pet.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    pImage = ms.ToArray();
                }
            }
            decimal price = decimal.Parse(txt_Price.Text);
            String status = cmb_Status.SelectedItem.ToString();
            int age = Int32.Parse(txt_Age.Text);
            string gender = cmb_Gender.SelectedItem.ToString();
            string stat = cmb_Status.SelectedItem.ToString();


            petRepo.AddPet(txt_petName.Text, txt_Species.Text, txt_Breed.Text, age, gender, stat, price, pImage);
            loadPets();
            ClearTextboxes();
        }

        public void ClearTextboxes()
        {
            txt_petName.Clear();
            txt_Species.Clear();
            txt_Breed.Clear();
            txt_Age.Clear();
            cmb_Gender.Text = "";
            cmb_Status.Text = "";
            pic_addPetImg.Image = null;
        }

        private void dg_Pets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_Pets.SelectedRows.Count > 0)
            {
                tempPetID = dg_Pets.SelectedRows[0].Cells[0].Value.ToString();
                txt_petName.Text = dg_Pets.SelectedRows[0].Cells[2].Value.ToString();
                txt_Species.Text = dg_Pets.SelectedRows[0].Cells[3].Value.ToString();
                txt_Breed.Text = dg_Pets.SelectedRows[0].Cells[4].Value.ToString();
                txt_Age.Text = dg_Pets.SelectedRows[0].Cells[5].Value.ToString();
                cmb_Gender.Text = dg_Pets.SelectedRows[0].Cells[6].Value.ToString();
                txt_Price.Text = dg_Pets.SelectedRows[0].Cells[8].Value.ToString();
                cmb_Status.Text = dg_Pets.SelectedRows[0].Cells[7].Value.ToString();

                byte[] imageData = (byte[])dg_Pets.SelectedRows[0].Cells[0].Value;
                if (imageData != null)
                {
                    // Convert byte array to image
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pic_Pet.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // If image data is null, clear the picture box
                    pic_Pet.Image = null;
                }

            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dg_Pets.Rows[e.RowIndex];

                // Retrieve the userID from the clicked row and store it
                deletepet = row.Cells[0].Value.ToString();
            }
        }

        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
