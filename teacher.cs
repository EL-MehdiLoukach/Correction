using System;

namespace Correction {

    // Teacher Class
    public class Teacher : AnneeCalcul, ICalcul, IComparable<Teacher>
    {
        // Attributes
        public string Matricule { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public double Salary { get; set; }
        public Vehicle Vehicle { get; set; }

        // Constructor
        public Teacher(string matricule, string lastName, string firstName, DateTime birthDate, DateTime hireDate, double salary, Vehicle vehicle)
        {
            Matricule = matricule;
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
            HireDate = hireDate;
            Salary = salary;
            Vehicle = vehicle;
        }

        // ToString method
        public override string ToString()
        {
            return $"Teacher - Matricule: {Matricule}, Name: {FirstName} {LastName}, Birth Date: {BirthDate}, Hire Date: {HireDate}, Salary: {Salary}, {Vehicle}";
        }
        // Implementing the abstract method
        public override int CalculerAnnee(DateTime date_Debut)
        {
            int years = DateTime.Now.Year - date_Debut.Year;
            return years;
        }

        // Implementing the Calcul abstract method
        public double CalculSalaireTotal()
        {
            // Add any additional logic for calculating total salary
            return Salary; // For simplicity, returning base salary
        }
         // Implementing the IComparable interface method
        public int CompareTo(Teacher other)
        {
            // Implement comparison logic based on your requirements
            // For simplicity, comparing by Matricule
            return Matricule.CompareTo(other.Matricule);
        }
    }
}
