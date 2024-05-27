using Hubitat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hubitat.Repositories
{
    public class TransactionRepository
    {
        private hubitatDBEntities db;
        public TransactionRepository() { db = new hubitatDBEntities(); }
        public ErrorCode BuyPet(String pID, decimal totalPay, decimal amountPay, decimal changePay)
        {
            try
            {
                using (db = new hubitatDBEntities())
                {

                    var trans = new Transactions();
                    var loggedInUser = UserLogged.GetInstance().User;

                    trans.transactionID = GenerateTransactionID();
                    trans.userID = loggedInUser.userID;
                    trans.petID = pID;
                    trans.totalPayment = totalPay;
                    trans.amountCustPay = amountPay;
                    trans.payChange = changePay;
                    trans.transDate = DateTime.Now;

                    db.Transactions.Add(trans);
                    db.SaveChanges();

                    MessageBox.Show("Ordered Successfuly!!");
                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return ErrorCode.Error;
            }
        }

        public string GenerateTransactionID()
        {
            string pID;
            var trnIDs = db.Transactions.Select(u => u.transactionID).ToList();

            // Find the maximum numeric part of the existing apartment IDs
            int nextNumericID = 1;
            if (trnIDs.Any())
            {
                var numericParts = trnIDs.Select(id => int.Parse(id.Split('-')[1]));
                nextNumericID = numericParts.Max() + 1;
            }

            // Format the new apartment ID
            return pID = "T-" + nextNumericID.ToString("000");
        }
    }
}
