using System;

namespace Correction {
    // Vehicle class
    public class Vehicle : AnneeCalcul, IComparable<Vehicle>
    {
        // Attributes
        public string RegistrationNumber { get; set; }
        public DateTime LaunchDate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        // Constructor
        public Vehicle(string registrationNumber, DateTime launchDate, string brand, string model)
        {
            RegistrationNumber = registrationNumber;
            LaunchDate = launchDate;
            Brand = brand;
            Model = model;
        }
        // ToString method
        public override string ToString()
        {
            return $"Vehicle - Registration Number: {RegistrationNumber}, Launch Date: {LaunchDate}, Brand: {Brand}, Model: {Model}";
        }
        // Implementing the IComparable interface method
        public int CompareTo(Vehicle other)
        {
            // Implement comparison logic based on your requirements
            // For simplicity, comparing by RegistrationNumber
            return RegistrationNumber.CompareTo(other.RegistrationNumber);
        }
         // Implementing the abstract method
        public override int CalculerAnnee(DateTime date_Debut)
        {
            int years = DateTime.Now.Year - date_Debut.Year;
            return years;
        }
    }
    public class VehiculeComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            // Check for null values
            if (x.RegistrationNumber == null && y.RegistrationNumber == null)
            {
                return 0; // Both are considered equal
            }
            else if (x.RegistrationNumber == null)
            {
                return -1; // Null is considered less than any non-null value
            }
            else if (y.RegistrationNumber == null)
            {
                return 1; // Any non-null value is considered greater than null
            }

            // Implement comparison logic based on your requirements
            // For simplicity, comparing by RegistrationNumber
            return x.RegistrationNumber.CompareTo(y.RegistrationNumber);
        }
    }
}

