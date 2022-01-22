using System.Collections.Generic;

namespace Homework1.Models
{
    public class Doctor
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Patient> Patients { get; set; }
    }
}