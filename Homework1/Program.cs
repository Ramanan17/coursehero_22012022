using System;
using System.Collections.Generic;
using Homework1.Models;

namespace Homework1
{
    class Program
    {
        
        public static List<Doctor> Doctors = new List<Doctor>()
        {
            new Doctor()
                {FirstName = "Kareem", LastName = "Dana", 
                    Patients = new List<Patient>()
                        {new Patient(){FirstName = "Jeff",LastName = "Babb"},new Patient(){FirstName = "Samantha",LastName = "Carter"}}},
            new Doctor()
            {FirstName = "Amjad", LastName = "Abdullat", 
                Patients = new List<Patient>()
                    {new Patient(){FirstName = "Daniel",LastName = "Jackson"},new Patient(){FirstName = "Jack",LastName = "O'Neill"},new Patient(){FirstName = "George",LastName = "Bush"}}},

            new Doctor()
            {FirstName = "Sean", LastName = "Humpherys", 
                Patients = new List<Patient>()
                    {new Patient(){FirstName = "George",LastName = "Hammond"},new Patient(){FirstName = "Elizabeth",LastName = "Weir"},new Patient(){FirstName = "Ibrahim",LastName="Lazrig"},new Patient(){FirstName = "Yao",LastName = "Ming"}}}
        };
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            foreach (var doctor in Doctors)
            {
                Console.WriteLine($"Dr. {doctor.FirstName} {doctor.LastName} has the following {doctor.Patients.Count} patients:");
                foreach (var patient in doctor.Patients)
                {
                    Console.WriteLine($" {patient.FirstName} {patient.LastName}");
                }
            }
        }
    }
}