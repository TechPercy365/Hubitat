using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hubitat.Model;

namespace Hubitat.Repositories
{
    public class PetRepository
    {
        private hubitatDBEntities db;
        public PetRepository() { db = new hubitatDBEntities(); }

        //public ErrorCode AddApartment(String aDesc, decimal aPrice, String aType, String aStatus, String img)
        //{
        //    try
        //    {
        //        using (db = new db_HubitatEntities())
        //        {
        //            var Apmt = new Apartments();

        //            Apmt.apmtID = GenerateApartmentID();
        //            Apmt.apmtDescription = aDesc;
        //            Apmt.apmtPrice = aPrice;
        //            Apmt.apmtType = aType;
        //            Apmt.apmtStatus = aStatus;
        //            Apmt.apmtImg = img;

        //            db.Apartments.Add(Apmt);
        //            db.SaveChanges();
        //        }
        //        return ErrorCode.Success;
        //    }
        //    catch (DbEntityValidationException ex)
        //    {
        //        // Iterate through validation errors
        //        foreach (var entityValidationError in ex.EntityValidationErrors)
        //        {
        //            foreach (var validationError in entityValidationError.ValidationErrors)
        //            {
        //                // Access details of each validation error
        //                string propertyName = validationError.PropertyName;
        //                string errorMessage = validationError.ErrorMessage;

        //                // Log or display the validation error details
        //                MessageBox.Show($"Validation error in {propertyName}: {errorMessage}");
        //            }
        //        }
        //        return ErrorCode.Error;
        //    }
        //}

        //public string GenerateApartmentID()
        //{
        //    string aID;
        //    var apmtIDs = db.Apartments.Select(u => u.apmtID).ToList();

        //    // Find the maximum numeric part of the existing apartment IDs
        //    int nextNumericID = 1;
        //    if (apmtIDs.Any())
        //    {
        //        var numericParts = apmtIDs.Select(id => int.Parse(id.Split('-')[1]));
        //        nextNumericID = numericParts.Max() + 1;
        //    }

        //    // Format the new apartment ID
        //    return aID = "AP-" + nextNumericID.ToString("000");
        //}


        //public ErrorCode RemoveApartment(string apID)
        //{
        //    ErrorCode retValue = ErrorCode.Error;
        //    try
        //    {
        //        using (db = new db_HubitatEntities())
        //        {
        //            Apartments apmt = db.Apartments.Where(u => u.apmtID == apID).FirstOrDefault();
        //            // Remove the user
        //            db.Apartments.Remove(apmt);
        //            db.SaveChanges();       // Execute the update

        //            MessageBox.Show("Deleted Successfully");
        //            retValue = ErrorCode.Success;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        retValue = ErrorCode.Error;
        //        MessageBox.Show(ex.Message);
        //    }
        //    return retValue;
        //}


    }
}
