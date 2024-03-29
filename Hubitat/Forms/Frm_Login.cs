using Hubitat.Forms;
using Hubitat.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hubitat
{
    public partial class Frm_Login : Form
    {
        db_HubitatEntities db;
        public Frm_Login()
        {
            InitializeComponent();
            db = new db_HubitatEntities();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            new Frm_Registration().Show();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Username.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Username, "Empty Field. Please Fill-in");
                return;
            }
            if (String.IsNullOrEmpty(txt_Password.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_Password, "Empty Field. Please Fill-in");
                return;
            }

            if (VerifyAccount(txt_Username.Text, txt_Password.Text)) {

                string usertype = GetUserType(txt_Username.Text);

                switch (usertype) {
                    case "TENANT":
                        new Frm_TenantDashboard().Show();
                        this.Hide();
                        break;
                    case "LANDLORD":
                        new Frm_LandlordDashboard().Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Unknown User Type.");
                        break;
                }

            }

        }
        public static byte[] HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Compute hash from the password
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                return bytes;
            }
        }

        public bool VerifyAccount(string uname, string pass) {
            using (var dbContext = new db_HubitatEntities())
            {
                // Retrieve the hashed password from the database for the provided username
                var user = dbContext.Users.FirstOrDefault(u => u.userName == uname);
                if (user != null)
                {
                    // Hash the password inputted by the user
                    byte[] hashedPasswordInput = HashPassword(pass);

                    // Compare hashed passwords
                    return hashedPasswordInput.SequenceEqual(user.userPass);
                }
            }
            return false; 
        }

        public string GetUserType(string username)
        {
            // Retrieve user type from the database based on the username
            var user = db.Users.FirstOrDefault(u => u.userName == username);

            if (user != null)
            {
                // Assuming the user type is stored in a property named UserType in the User entity
                return user.userType;
            }
            else
            {
                // Handle case where user does not exist
                return null;
            }
        }

        private void img_ShowPassword_Click(object sender, EventArgs e)
        {
            if (txt_Password.UseSystemPasswordChar)
            {
                txt_Password.UseSystemPasswordChar = false;
                img_ShowPassword.Image = Properties.Resources.icon_showPass;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;
                img_ShowPassword.Image = Properties.Resources.icon_hidePass;
            }
        }

        private void x_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
