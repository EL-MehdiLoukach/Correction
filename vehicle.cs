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
}

