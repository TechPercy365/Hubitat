using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hubitat.Model;

namespace Hubitat.Repositories
{
    public class UserRepository
    {
        private db_HubitatEntities db;
        public UserRepository() { db = new db_HubitatEntities(); }

        public ErrorCode RegisterUser(String uName, String uPass, String uType, String fname, String lname, String uEmail, String phone)
        {
            try
            {
                using (db = new db_HubitatEntities()) {

                    var newUser = new Users();
                    var newInfo = new UserInfo();                   

                    newUser.userID = GenerateUserID();
                    newUser.userName = uName;
                    newUser.userPass = HashPassword(uPass);
                    newUser.userType = uType;

                    newInfo.userID = GenerateUserID();
                    newInfo.firstName = fname;
                    newInfo.lastName = lname;
                    newInfo.email = uEmail;
                    newInfo.phoneNum = phone;

                    db.Users.Add(newUser);
                    db.UserInfo.Add(newInfo);
                    db.SaveChanges();


                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +ex.Message);
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

        public ErrorCode RemoveUser(string userid, ref String outMessage) {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                using (db = new db_HubitatEntities())
                {
                    Users user = db.Users.Where(m => m.userID == userid).FirstOrDefault();
                    UserInfo info = db.UserInfo.Where(m => m.userID == userid).FirstOrDefault();
                    // Remove the user
                    db.Users.Remove(user);
                    db.UserInfo.Remove(info);
                    db.SaveChanges();       // Execute the update

                    outMessage = "Deleted Successfully";
                    retValue = ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                retValue = ErrorCode.Error;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }

        //public ErrorCode EditUserInfo() {
        //    try
        //    {
        //        using (db = new db_HubitatEntities())
        //        {
        //            // Call the create stored procedure
        // STORED PROCEDURE    db.sp_UpdateProduct(productID, productName, productType, productPrice);
        //            MessageBox.Show("User Updated Successfully");
        //            return ErrorCode.Success;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return ErrorCode.Error;
        //    }
        //}

        //public List<Users> AllUserRole()
        //{
        //    using (db = new db_HubitatEntities())
        //    {
        //        return db.vw_AllUsers.ToList();
        //    }
        //}

        //public ErrorCode SearchUserNameOrUserID() { 

        //}

    }
}
