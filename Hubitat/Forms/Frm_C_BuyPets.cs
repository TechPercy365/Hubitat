using Hubitat.Model;
using Hubitat.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hubitat.Forms
{
    public partial class Frm_C_BuyPets : Form
    {
        hubitatDBEntities db;
        PetRepository petRepo;
        TransactionRepository tranRepo;
        private string fname;
        private string lname;
        private string email;
        private string uID;
        private string tempPetID;
        private string price;

        public Frm_C_BuyPets(string uID,string fname, string lname, string email)
        {
            InitializeComponent();
            db = new hubitatDBEntities();
            petRepo = new PetRepository();
            tranRepo = new TransactionRepository();
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.uID = uID;
            loadPetBuy();            
        }

        private void x_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            new Frm_CustomerDashboard().Show();
            this.Hide();
        }

        private void label_Home_Click(object sender, EventArgs e)
        {
            new Frm_CustomerDashboard().Show();
            this.Hide();
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txt_Amount.Text))
            {
                lbl_Error.Text = "Please Enter the Amount you will Pay first";
                return;
            }

            decimal totalPay = decimal.Parse(price);
            decimal amt = decimal.Parse(txt_Amount.Text);
            decimal change = (amt - totalPay);
            string stat = "SOLD";
            tranRepo.BuyPet(tempPetID, totalPay, amt, change);
            petRepo.UpdatePetStatus(tempPetID, stat);
            loadPetBuy();
            ClearInputs();
            

        }

        public void ClearInputs()
        {
            txt_Amount.Clear();
            pic_petImg.Image = null;
        }

        public void loadPetBuy()
        {            

            dgv_butPet.DataSource = db.vw_BuyPet.ToList();

            lbl_CusName.Text = $"Name: {fname} {lname} ";
            lbl_Email.Text = $"Email {email} ";

            var pets = db.vw_BuyPet.ToList();                       

        }

        private void dgv_butPet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_butPet.Rows[e.RowIndex];
                
                string petId = Convert.ToString(row.Cells[0].Value);
                DisplayPetInfo(petId);
            }
        }

        private void DisplayPetInfo(string petId)
        {
            using (var dbContext = new hubitatDBEntities())
            {
                var pet = dbContext.Pets.FirstOrDefault(p => p.petID == petId);
                if (pet != null)
                {
                    price = pet.petPrice.ToString();
                    tempPetID = pet.petID;
                    // Display pet info in the transaction panel
                    lbl_PetName.Text = "Pet Name: " + pet.petName;
                    lbl_Species.Text = "Species: " + pet.petSpecies;
                    lbl_Breed.Text = "Breed: " + pet.petBreed;
                    lbl_Price.Text = "Price: " + price;

                    
                    if (pet.petImage != null && pet.petImage.Length > 0)
                    {
                        // Convert byte array to image
                        using (MemoryStream ms = new MemoryStream(pet.petImage))
                        {
                            pic_petImg.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        // If image data is null, clear the picture box
                        pic_petImg.Image = null;
                    }

                }
            }
        }

        private void txt_Amount_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
