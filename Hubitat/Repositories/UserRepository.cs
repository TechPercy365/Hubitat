using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hubitat.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hubitat.Repositories
{
    public class UserRepository
    {
        private hubitatDBEntities db;
        public UserRepository() { db = new hubitatDBEntities(); }

        public ErrorCode RegisterUser(String uName, String uPass, String uType, String fname, String lname, String uEmail, String phone)
        {
            try
            {
                using (db = new hubitatDBEntities())
                {

                    var newUser = new Users();                    

                    newUser.userID = GenerateUserID();
                    newUser.userName = uName;
                    newUser.userPass = HashPassword(uPass);
                    newUser.userType = uType;                    
                    newUser.firstName = fname;
                    newUser.lastName = lname;
                    newUser.email = uEmail;
                    newUser.phoneNum = phone;
                    newUser.dateCreated = DateTime.Now;

                    db.Users.Add(newUser);                    
                    db.SaveChanges();

                    MessageBox.Show("Account Created Successfuly!!");
                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return ErrorCode.Error;
            }
        }

        public string GenerateUserID()
        {
            string uID;
            var userIDs = db.Users.Select(u => u.userID).ToList();

            // Find the maximum numeric part of the existing user IDs
            int nextNumericID = 1;
            if (userIDs.Any())
            {
                var numericParts = userIDs.Select(id => int.Parse(id.Split('-')[1]));
                nextNumericID = numericParts.Max() + 1;
            }

            // Format the new user ID
            return uID = "U-" + nextNumericID.ToString("000");
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

        public ErrorCode RemoveUser(string userid)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                using (db = new hubitatDBEntities())
                {
                    Users user = db.Users.Where(m => m.userID == userid).FirstOrDefault();                    
                    // Remove the user
                    db.Users.Remove(user);                    
                    db.SaveChanges();       // Execute the update

                    MessageBox.Show("Deleted Successfully");
                    retValue = ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                retValue = ErrorCode.Error;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }

        public ErrorCode EditUser(String id, String username, String utype, String fname, String lname, String email, String phone)
        {
            try
            {
                DateTime dateCreated = DateTime.Now;
                using (db = new hubitatDBEntities())
                {
                    //Call the create stored procedure
                    db.sp_UserUpdate(id, username, utype, fname, lname, email, phone, dateCreated);
                    MessageBox.Show("Updated Successfully");
                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:", ex.Message);
                return ErrorCode.Error;
            }
        }

        public ErrorCode CreateAdm(String uName, String uPass, String uType, String fname, String lname, String uEmail, String phone)
        {
            try
            {
                using (db = new hubitatDBEntities())
                {

                    var newUser = new Users();

                    newUser.userID = GenerateUserID();
                    newUser.userName = uName;
                    newUser.userPass = HashPassword(uPass);
                    newUser.userType = uType;
                    newUser.firstName = fname;
                    newUser.lastName = lname;
                    newUser.email = uEmail;
                    newUser.phoneNum = phone;
                    newUser.dateCreated = DateTime.Now;

                    db.Users.Add(newUser);
                    db.SaveChanges();

                    MessageBox.Show("Owner Created Successfuly!!");
                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return ErrorCode.Error;
            }
        }


    }
}
