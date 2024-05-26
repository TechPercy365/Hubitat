using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hubitat.Model;
using Hubitat.Repositories;

namespace Hubitat.Forms
{
    public partial class Frm_ManagePets : Form
    {
        hubitatDBEntities db;
        PetRepository petRepo;
        private byte[] pImage;
        private string deletePet;
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
    }
}
