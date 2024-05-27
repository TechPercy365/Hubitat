using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Hubitat.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hubitat.Repositories
{
    public class PetRepository
    {
        private hubitatDBEntities db;
        public PetRepository() { db = new hubitatDBEntities(); }

        public ErrorCode AddPet(String name, String species, String breed, int age, String gender, String status, decimal price, byte[] img)
        {
            try
            {
                using (db = new hubitatDBEntities())
                {
                    var pet = new Pets();

                    pet.petID = GeneratePetID();
                    pet.petName = name;
                    pet.petSpecies = species;
                    pet.petBreed = breed;
                    pet.petAge = age;
                    pet.petGender = gender;
                    pet.petStatus = status;
                    pet.petPrice = price;
                    pet.petImage = img;

                    db.Pets.Add(pet);
                    db.SaveChanges();
                }
                return ErrorCode.Success;
            }
            catch (DbEntityValidationException ex)
            {
                // Iterate through validation errors
                foreach (var entityValidationError in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationError.ValidationErrors)
                    {
                        // Access details of each validation error
                        string propertyName = validationError.PropertyName;
                        string errorMessage = validationError.ErrorMessage;

                        // Log or display the validation error details
                        MessageBox.Show($"Validation error in {propertyName}: {errorMessage}");
                    }
                }
                return ErrorCode.Error;
            }
        }

        public string GeneratePetID()
        {
            string pID;
            var apmtIDs = db.Pets.Select(u => u.petID).ToList();

            // Find the maximum numeric part of the existing apartment IDs
            int nextNumericID = 1;
            if (apmtIDs.Any())
            {
                var numericParts = apmtIDs.Select(id => int.Parse(id.Split('-')[1]));
                nextNumericID = numericParts.Max() + 1;
            }

            // Format the new apartment ID
            return pID = "P-" + nextNumericID.ToString("000");
        }


        public ErrorCode RemovePet(string pID)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                using (db = new hubitatDBEntities())
                {
                    Pets rmpet = db.Pets.Where(u => u.petID == pID).FirstOrDefault();
                    // Remove the user
                    db.Pets.Remove(rmpet);
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

        public ErrorCode EditPet(String pID, String name, String species, String breed, int age, String gender, String status, decimal price, byte[] img)
        {
            try
            {                
                using (db = new hubitatDBEntities())
                {
                    //Call the create stored procedure
                    db.sp_PetUpdate(pID, name, species, breed, age, gender, status, price, img);
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


    }
}
