using System;
using System.Collections.Generic;

namespace Correction {
    public class Program {
        static void Main()
        {
            // Create a list of vehicles
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Vehicle("ABC123", new DateTime(2020, 1, 1), "Toyota", "Camry"),
                new Vehicle("XYZ789", new DateTime(2019, 3, 15), "Honda", "Accord"),
                // Add more vehicles as needed
            };

            // Create a list of students
            List<Student> students = new List<Student>
            {
                new Student(1, "Doe", "John", new DateTime(2000, 5, 10), "Senior", "Computer Science", vehicles[0]),
                new Student(2, "Smith", "Jane", new DateTime(2001, 8, 25), "Junior", "Electrical Engineering", vehicles[1]),
                // Add more students as needed
            };

            // Create a list of teachers
            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher("T001", "Johnson", "Robert", new DateTime(1985, 2, 20), new DateTime(2010, 6, 1), 50000, vehicles[0]),
                new Teacher("T002", "Williams", "Emily", new DateTime(1978, 9, 5), new DateTime(2015, 3, 10), 60000, vehicles[1]),
                // Add more teachers as needed
            };

            // Display menu
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Display sorted list of students");
                Console.WriteLine("2. Display sorted list of vehicles");
                Console.WriteLine("3. Calculate age of a person");
                Console.WriteLine("4. Calculate vehicle's seniority");
                Console.WriteLine("5. Calculate total salary of a teacher");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice (1-6): ");

                // Get user input
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            DisplaySortedStudents(students);
                            break;
                        case 2:
                            DisplaySortedVehicles(vehicles);
                            break;
                        case 3:
                            CalculateAge();
                            break;
                        case 4:
                            CalculateVehicleSeniority();
                            break;
                        case 5:
                            CalculateTeacherTotalSalary(teachers);
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        // Method to display sorted list of students
        static void DisplaySortedStudents(List<Student> students)
        {
            students.Sort();
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        // Method to display sorted list of vehicles
        static void DisplaySortedVehicles(List<Vehicle> vehicles)
        {
            vehicles.Sort();
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }

        // Method to calculate age of a person
        static void CalculateAge()
        {
            // Get the birthdate from the user (replace with actual input)
            Console.Write("Enter the birthdate (yyyy-MM-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime birthdate))
            {
                int age = new Student(0, "", "", birthdate, "", "", null).CalculerAnnee(birthdate);
                Console.WriteLine($"The age is: {age} years");
            }
            else
            {
                Console.WriteLine("Invalid date format.");
            }
        }

        // Method to calculate vehicle's seniority
        static void CalculateVehicleSeniority()
        {
            // Get the launch date from the user (replace with actual input)
            Console.Write("Enter the vehicle launch date (yyyy-MM-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime launchDate))
            {
                // You need to provide the necessary information for the Vehicle instance
                Console.Write("Enter the registration number: ");
                string registrationNumber = Convert.ToString(Console.ReadLine());

                Console.Write("Enter the brand: ");
                string brand = Convert.ToString(Console.ReadLine());

                Console.Write("Enter the model: ");
                string model = Convert.ToString(Console.ReadLine());

                // Create a new Vehicle instance with the provided information
                Vehicle v = new Vehicle(registrationNumber, launchDate, brand, model);

                // Calculate seniority using the created Vehicle instance
                int seniority = v.CalculerAnnee(launchDate);

                Console.WriteLine($"The vehicle seniority is: {seniority} years");
            }
            else
            {
                Console.WriteLine("Invalid date format.");
            }
        }


        // Method to calculate total salary of a teacher
        static void CalculateTeacherTotalSalary(List<Teacher> teachers)
        {
            // Get the index of the teacher from the user (replace with actual input)
            Console.Write("Enter the index of the teacher: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < teachers.Count)
            {
                double totalSalary = teachers[index].CalculSalaireTotal();
                Console.WriteLine($"The total salary of the teacher is: {totalSalary} DH");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

    }
}