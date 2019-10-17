using System;
using System.Collections.Generic;
using System.Text;

namespace TestarTentan
{
    class Dentalhygenisist : Dentist
    {
        public Dentalhygenisist(string firstName, string lastName, string socialSecurityNumber, string phoneNumber, string email, string id, int salary) 
            : base(firstName, lastName, socialSecurityNumber, phoneNumber, email, id, salary)
        {
        }

        public string DentalHMessage()
        {
            string hello = "Dental hygenisist";

            return hello;
        }

       

    }
}
