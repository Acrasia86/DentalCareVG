using System;
using System.Collections.Generic;

namespace TestarTentan
{
    class Program
    {
        public static Dictionary<string, Patient> patientList = new Dictionary<string, Patient>();

        static void Main(string[] args)
        {
            

            var start = new Menu();

            start.Menus();
        }
    }
}
