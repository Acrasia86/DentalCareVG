using System;
using System.Collections.Generic;
using System.Text;

namespace TestarTentan
{
    class Reservation
    {
        public Reservation(string socialSecurityNumber, string reasonForVisit, string dentist, DateTime date)
        {
            
            SocialSecurityNumber = socialSecurityNumber;
            ReasonForVisit = reasonForVisit;
            Dentist = dentist;
            Date = date;
        }

   
        public string SocialSecurityNumber { get; }

        public string ReasonForVisit { get; }
        public string Dentist { get; }
        public DateTime Date { get; }
    }
}
