using System;


namespace Correction {

    public class Student : AnneeCalcul, IComparable<Student>
    {
        // Attributes
        public int Number { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Level { get; set; }
        public string Branch { get; set; }
        public Vehicle Vehicle { get; set; }

        // Constructor
        public Student(int number, string lastName, string firstName, DateTime birthDate, string level, string branch, Vehicle vehicle)
        {
            Number = number;
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
            Level = level;
            Branch = branch;
            Vehicle = vehicle;
        }

        // ToString method
        public override string ToString()
        {
            return $"Student - Number: {Number}, Name: {FirstName} {LastName}, Birth Date: {BirthDate}, Level: {Level}, Branch: {Branch}, {Vehicle}";
        }
        // Implementing the abstract method
        public override int CalculerAnnee(DateTime date_Debut)
        {
            int years = DateTime.Now.Year - date_Debut.Year;
            return years;
        }
        // Implementing the IComparable interface method
        public int CompareTo(Student other)
        {
            // Implement comparison logic based on your requirements
            // For simplicity, comparing by Number
            return Number.CompareTo(other.Number);
        }
    }
    // Custom comparer class for Student
    public class StudentComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            // Check for null values
            if (x.Number == null && y.Number == null)
            {
                return 0; // Both are considered equal
            }
            else if (x.Number == null)
            {
                return -1; // Null is considered less than any non-null value
            }
            else if (y.Number == null)
            {
                return 1; // Any non-null value is considered greater than null
            }

            // Implement comparison logic based on your requirements
            // For simplicity, comparing by Number
            return x.Number.CompareTo(y.Number);
        }
    }

}
