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
    public partial class Frm_Registration : Form
    {
        db_HubitatEntities db;
        private UserRepository userRepo;
        public Frm_Registration()
        {
            InitializeComponent();
            db = new db_HubitatEntities();
            userRepo = new UserRepository();
        }

        private void pic_Back_Click(object sender, EventArgs e)
        {
            new Frm_Login().Show();
            this.Hide();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Uname.Clear();
            txt_Fname.Clear();
            txt_Email.Clear();
            txt_PhoneNum.Clear();
            txt_Password.Clear();
            txt_ConfirmPass.Clear();
            txt_Lname.Clear();            
        }       

        private void img_ShowPassword1_Click(object sender, EventArgs e)
        {
            if (txt_Password.UseSystemPasswordChar)
            {
                txt_Password.UseSystemPasswordChar = false;
                img_ShowPassword1.Image = Properties.Resources.icon_showPass;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;
                img_ShowPassword1.Image = Properties.Resources.icon_hidePass;
            }
        }
        private void img_showPass2_Click(object sender, EventArgs e)
        {
            if (txt_ConfirmPass.UseSystemPasswordChar)
            {
                txt_ConfirmPass.UseSystemPasswordChar = false;
                img_showPass2.Image = Properties.Resources.icon_showPass;
            }
            else
            {
                txt_ConfirmPass.UseSystemPasswordChar = true;
                img_showPass2.Image = Properties.Resources.icon_hidePass;
            }
        }

        private void x_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (!(txt_ConfirmPass.Text.Equals(txt_Password.Text)))
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_ConfirmPass, "Password does not Match. Try again.");
                ClearTextboxes();
                return;
            }

            if (checkUserNameExist(txt_Uname.Text))
            {
                MessageBox.Show("Username " +txt_Uname.Text+ " is already existed. Unable to Sign-up.", "INFORMATION", MessageBoxButtons.OK);
                ClearTextboxes();
                return;
            }
            if (String.IsNullOrEmpty(txt_Fname.Text)) {
                errorProvider.Clear();
                errorProvider.SetError(txt_Fname, "Empty Field. Please Fill-in."); 
                return; 
            }
            if (String.IsNullOrEmpty(txt_Lname.Text)) {
                errorProvider.Clear();
                errorProvider.SetError(txt_Lname, "Empty Field. Please Fill-in."); 
                return; 
            }
            if (String.IsNullOrEmpty(txt_Uname.Text)) {
                errorProvider.Clear();
                errorProvider.SetError(txt_Uname, "Empty Field. Please Fill-in."); 
                return; 
            }
            if (String.IsNullOrEmpty(txt_Email.Text)) {
                errorProvider.Clear();
                errorProvider.SetError(txt_Email, "Empty Field. Please Fill-in."); 
                return; 
            }
            if (String.IsNullOrEmpty(txt_PhoneNum.Text)) {
                errorProvider.Clear();
                errorProvider.SetError(txt_PhoneNum, "Empty Field. Please Fill-in."); 
                return; 
            }
            if (String.IsNullOrEmpty(txt_Password.Text)) {
                errorProvider.Clear();
                errorProvider.SetError(txt_Password, "Empty Field. Please Fill-in."); 
                return; 
            }
            if (String.IsNullOrEmpty(txt_ConfirmPass.Text)) { 
                errorProvider.SetError(txt_ConfirmPass, "Empty Field. Please Fill-in."); 
                return; 
            }
            if (String.IsNullOrEmpty(cmb_Role.Text)) {
                errorProvider.Clear();
                errorProvider.SetError(cmb_Role, "Empty Field. Please Fill-in."); 
                return; 
            }
            
            errorProvider.Clear();
            string type = cmb_Role.SelectedItem.ToString();
            userRepo.RegisterUser(txt_Uname.Text, txt_ConfirmPass.Text, type, txt_Fname.Text, txt_Lname.Text, txt_Email.Text, txt_PhoneNum.Text);
            MessageBox.Show("Successfully Registered. You can now Login.");
            ClearTextboxes();

        }

        public void ClearTextboxes() {
            txt_Fname.Clear();
            txt_Lname.Clear();
            txt_Uname.Clear();
            txt_Email.Clear();
            txt_PhoneNum.Clear();
            txt_Password.Clear();
            txt_ConfirmPass.Clear();
            cmb_Role.SelectedIndex = -1;
        }

        public static bool checkUserNameExist(string username)
        {
            using (var db = new db_HubitatEntities())
            {
                // Check if a user with the given username already exists in the database
                return db.Users.Any(u => u.userName == username);
            }
        }
    }
}
