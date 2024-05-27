using Hubitat.Model;
using Hubitat.Repositories;
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
    public partial class Frm_C_BuyPets : Form
    {
        hubitatDBEntities db;
        PetRepository petRepo;
        private string fname;
        private string lname;
        private string email;
        private string uID;

        public Frm_C_BuyPets(string uID,string fname, string lname, string email)
        {
            InitializeComponent();
            db = new hubitatDBEntities();
            petRepo = new PetRepository();
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
                lbl_Error.Text = "Please Enter an Amount you would like to Pay in the Pet you Choosed...";
                return;
            }

        }

        public void loadPetBuy()
        {
            dgv_butPet.DataSource = db.vw_BuyPet.ToList();
            lbl_CusName.Text = $"Name: {fname} {lname} ";
            lbl_Email.Text = $"Email {email} ";           
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
                    // Display pet info in the transaction panel
                    lbl_PetName.Text = "Pet Name: " + pet.petName;
                    lbl_Species.Text = "Species: " + pet.petSpecies;
                    lbl_Breed.Text = "Breed: " + pet.petBreed;
                    lbl_Price.Text = "Price: " + pet.petPrice.ToString();                    
                                       
                }
            }
        }

        private void dgv_butPet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_butPet.Columns[e.ColumnIndex].Name == "Pet_Image" && e.Value != null)
            {
                byte[] imageData = (byte[])e.Value;
                using (var ms = new System.IO.MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms);
                    e.Value = ResizeImage(image, 150, 150);
                }
            }
        }
        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(b))
            {
                g.DrawImage(img, 0, 0, width, height);
            }
            return b;
        }        

    }
}
