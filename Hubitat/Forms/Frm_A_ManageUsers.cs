using Hubitat.Model;
using Hubitat.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hubitat.Forms
{
    public partial class Frm_A_ManageUsers : Form
    {
        UserRepository userRepo;
        hubitatDBEntities db;

        private string deleteuser;
        private string tempID;
        public Frm_A_ManageUsers()
        {
            InitializeComponent();
            db = new hubitatDBEntities();
            userRepo = new UserRepository();
            loadUsers();
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

        public void loadUsers()
        {
            dgv_Users.DataSource = db.vw_Users.ToList();
        }

        private void btn_sortAll_Click(object sender, EventArgs e)
        {
            loadUsers();
            
            btn_sortAll.BackColor = Color.WhiteSmoke;
            btn_sortCust.BackColor = Color.FromArgb(127, 228, 232);
            btn_sortEmp.BackColor = Color.FromArgb(127, 228, 232);

            if (!(txt_Search.Text == "Search..." || String.IsNullOrEmpty(txt_Search.Text)))
            {
                SearchUser();
            }
        }       

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string utype = cmb_Role.SelectedItem.ToString();
            userRepo.RegisterUser(txt_Uname.Text, txt_Pass.Text, utype, txt_Fname.Text, txt_Lname.Text, txt_Email.Text, txt_Phone.Text);
            loadUsers();
            

        }
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            SearchUser();
        }
        public void SearchUser()
        {
            string title = txt_Search.Text.Trim();

            if (btn_sortAll.BackColor == Color.WhiteSmoke)
            {
                this.dgv_Users.DataSource = db.vw_Users.Where(x => x.Username.Contains(title) || x.User_ID.Contains(title)).OrderBy(x => x.User_ID).ToList();
            }
            else if (btn_sortCust.BackColor == Color.WhiteSmoke)
            {
                this.dgv_Users.DataSource = db.vw_Customers.Where(x => x.Username.Contains(title) || x.User_ID.Contains(title)).OrderBy(x => x.User_ID).ToList();
            }
            else if (btn_sortEmp.BackColor == Color.WhiteSmoke)
            {
                this.dgv_Users.DataSource = db.vw_Employees.Where(x => x.Username.Contains(title) || x.User_ID.Contains(title)).OrderBy(x => x.User_ID).ToList();
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(deleteuser))
                {
                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                // Call the method to delete the user by userID
                    userRepo.RemoveUser(deleteuser);
                
                loadUsers();
                }
            }
                            
            else
            {
                MessageBox.Show("Please select a user to delete.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_Users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Users.SelectedRows.Count > 0)
            {
                tempID = dgv_Users.SelectedRows[0].Cells[0].Value.ToString();
                txt_Fname.Text = dgv_Users.SelectedRows[0].Cells[3].Value.ToString();
                txt_Lname.Text = dgv_Users.SelectedRows[0].Cells[4].Value.ToString();
                txt_Email.Text = dgv_Users.SelectedRows[0].Cells[5].Value.ToString();
                txt_Phone.Text = dgv_Users.SelectedRows[0].Cells[6].Value.ToString();
                txt_Uname.Text = dgv_Users.SelectedRows[0].Cells[1].Value.ToString();
                cmb_Role.Text = dgv_Users.SelectedRows[0].Cells[2].Value.ToString();                
            }
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Users.Rows[e.RowIndex];

                // Retrieve the userID from the clicked row and store it
                deleteuser = row.Cells["User_ID"].Value.ToString();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            userRepo.EditUser(tempID, txt_Uname.Text, cmb_Role.Text, txt_Fname.Text, txt_Lname.Text, txt_Email.Text, txt_Phone.Text);
            loadUsers();
        }

        private void btn_sortCust_Click(object sender, EventArgs e)
        {
            dgv_Users.DataSource = db.vw_Customers.ToList();

            btn_sortAll.BackColor = Color.FromArgb(127, 228, 232);
            btn_sortCust.BackColor = Color.WhiteSmoke;
            btn_sortEmp.BackColor = Color.FromArgb(127, 228, 232);

            if (!(txt_Search.Text == "Search..." || String.IsNullOrEmpty(txt_Search.Text)))
            {
                SearchUser();
            }
        }

        private void btn_sortEmp_Click(object sender, EventArgs e)
        {
            dgv_Users.DataSource = db.vw_Employees.ToList();

            btn_sortAll.BackColor = Color.FromArgb(127, 228, 232);
            btn_sortCust.BackColor = Color.FromArgb(127, 228, 232);
            btn_sortEmp.BackColor = Color.WhiteSmoke;

            if (!(txt_Search.Text == "Search..." || String.IsNullOrEmpty(txt_Search.Text)))
            {
                SearchUser();
            }
        }
    }
}
