using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hubitat.Model;
using Hubitat.Repositories;
//using static System.Windows.Forms.AxHost;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hubitat.Forms
{
    public partial class Frm_ManagePets : Form
    {
        hubitatDBEntities db;
        PetRepository petRepo;
        private byte[] pImage;
        string deletePet;
        private string tempPetId;

        public Frm_ManagePets()
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
            dgvPets.DataSource = db.vw_AllPets.ToList();
        }
        public void searchPet()
        {
            string title = txtSearch.Text.Trim();

            if (btnSortAll.BackColor == Color.Black)
            {
                this.dgvPets.DataSource = db.vw_AllPets.Where(x => x.Pet_Name.Contains(title) || x.Pet_ID.Contains(title)).OrderBy(x => x.Pet_ID).ToList();
            }
            else if (btnSortAvailable.BackColor == Color.Black)
            {
                this.dgvPets.DataSource = db.vw_PetAvailable.Where(x => x.Pet_Name.Contains(title) || x.Pet_ID.Contains(title)).OrderBy(x => x.Pet_ID).ToList();
            }
            else if (btnSortSold.BackColor == Color.Black)
            {
                this.dgvPets.DataSource = db.vw_PetSold.Where(x => x.Pet_Name.Contains(title) || x.Pet_ID.Contains(title)).OrderBy(x => x.Pet_ID).ToList();
            }
        }

        private void btnSortAll_Click(object sender, EventArgs e)
        {
            loadPets();

            btnSortAll.BackColor = Color.Black;
            btnSortAll.ForeColor = Color.FromArgb(127, 228, 232);
            btnSortAvailable.BackColor = Color.FromArgb(127, 228, 232);
            btnSortAvailable.ForeColor = Color.Black;
            btnSortSold.BackColor = Color.FromArgb(127, 228, 232);
            btnSortSold.ForeColor = Color.Black;

            if (!(txtSearch.Text == "Search..." || String.IsNullOrEmpty(txtSearch.Text)))
            {
                searchPet();
            }
        }

        private void btnSortAvailable_Click(object sender, EventArgs e)
        {
            dgvPets.DataSource = db.vw_PetAvailable.ToList();

            btnSortAll.BackColor = Color.FromArgb(127, 228, 232);
            btnSortAll.ForeColor = Color.Black;
            btnSortAvailable.BackColor = Color.Black;
            btnSortAvailable.ForeColor = Color.FromArgb(127, 228, 232);
            btnSortSold.BackColor = Color.FromArgb(127, 228, 232);
            btnSortSold.ForeColor = Color.Black;

            if (!(txtSearch.Text == "Search..." || String.IsNullOrEmpty(txtSearch.Text)))
            {
                searchPet();
            }
        }

        private void btnSortSold_Click(object sender, EventArgs e)
        {
            dgvPets.DataSource = db.vw_PetSold.ToList();

            btnSortAll.BackColor = Color.FromArgb(127, 228, 232);
            btnSortAll.ForeColor = Color.Black;
            btnSortAvailable.BackColor = Color.FromArgb(127, 228, 232);
            btnSortAvailable.ForeColor = Color.Black;
            btnSortSold.BackColor = Color.Black;
            btnSortSold.ForeColor = Color.FromArgb(127, 228, 232);

            if (!(txtSearch.Text == "Search..." || String.IsNullOrEmpty(txtSearch.Text)))
            {
                searchPet();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchPet();
        }

        private void picAddPet_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPrice.Text) || String.IsNullOrEmpty(cmbStatus.Text))
            {
                MessageBox.Show("Please Enter the Price and the Status of the Apartment before adding it.");
                return;
            }

            if (picShowPet.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    picShowPet.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    pImage = ms.ToArray();
                }
            }
            decimal price = decimal.Parse(txtPrice.Text);            
            int age = Int32.Parse(txtPAge.Text);
            string gender = cmbGender.SelectedItem.ToString();
            string stat = cmbStatus.SelectedItem.ToString();


            petRepo.AddPet(txtPName.Text, txtPSpecies.Text, txtPBreed.Text, age, gender, stat, price, pImage);
            loadPets();
            ClearTextboxes();
        }

        public void ClearTextboxes()
        {
            txtPName.Clear();
            txtPSpecies.Clear();
            txtPBreed.Clear();
            txtPAge.Clear();
            cmbGender.Text = "";
            txtPrice.Clear();
            cmbStatus.Text = "";
            picShowPet.Image = null;
        }

        private void picChooseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                picShowPet.Image = new Bitmap(openfile.FileName);
            }
            else
            {
                MessageBox.Show("Error: Cannot add Image. Pleae Try Again.");
            }
        }

        private void picDeletePet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(deletePet))
            {
                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to Delete this Pet?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Call the method to delete the user by userID
                    petRepo.RemovePet(deletePet);

                    loadPets();
                    ClearTextboxes();
                }
            }

            else
            {
                MessageBox.Show("Please select a user to delete.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvPets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPets.SelectedRows.Count > 0)
            {
                tempPetId = dgvPets.SelectedRows[0].Cells[0].Value.ToString();
                txtPName.Text = dgvPets.SelectedRows[0].Cells[2].Value.ToString();
                txtPSpecies.Text = dgvPets.SelectedRows[0].Cells[3].Value.ToString();
                txtPBreed.Text = dgvPets.SelectedRows[0].Cells[4].Value.ToString();
                txtPAge.Text = dgvPets.SelectedRows[0].Cells[5].Value.ToString();
                cmbGender.Text = dgvPets.SelectedRows[0].Cells[6].Value.ToString();
                txtPrice.Text = dgvPets.SelectedRows[0].Cells[8].Value.ToString();
                cmbStatus.Text = dgvPets.SelectedRows[0].Cells[7].Value.ToString();

                byte[] imageData = (byte[])dgvPets.SelectedRows[0].Cells[0].Value;
                if (imageData != null)
                {
                    // Convert byte array to image
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        picShowPet.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // If image data is null, clear the picture box
                    picShowPet.Image = null;
                }

            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPets.Rows[e.RowIndex];

                // Retrieve the userID from the clicked row and store it
                deletePet = row.Cells["Pet_ID"].Value.ToString();
            }
        }
        
    }
}
