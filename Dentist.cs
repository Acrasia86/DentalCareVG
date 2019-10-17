using System;
using System.Collections.Generic;
using System.Text;

namespace TestarTentan
{
    class Dentist : RegisterHuman
    {
        public Dentist(string firstName, string lastName, string socialSecurityNumber, string phoneNumber, string email, string id, int salary)
            : base(firstName, lastName, socialSecurityNumber, phoneNumber, email)
        {
            Id = id;
            Salary = salary;
        }

        public string Id { get; }
        public int Salary { get; }

       public string DentistMessage()
        {
            string hello = "Dentist";

            return hello;
            
        }
    }


}
