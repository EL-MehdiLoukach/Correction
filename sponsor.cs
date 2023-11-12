using System;

namespace Correction {

// Sponsor class
    public class Sponsor : Teacher
    {
        // Constructor
        public Sponsor(string matricule, string lastName, string firstName, DateTime birthDate, DateTime hireDate, double salary, Vehicle vehicle)
            : base(matricule, lastName, firstName, birthDate, hireDate, salary, vehicle)
        {
        }

        // Method to calculate sponsorship bonus
        public double CalculateSponsorshipBonus(int numberOfStudents)
        {
            return numberOfStudents * 70; // 70 DH per student
        }
    }


}