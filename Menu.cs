using System;
using System.Collections.Generic;
using System.Text;

namespace TestarTentan
{
    class Menu
    {
        public void Menus()
        {
            Patient patient = new Patient();
            

            bool shouldNotExit = true;

            Console.Clear();

            while (shouldNotExit)
            {
                Console.WriteLine("1. Skapa reservation");
                Console.WriteLine("2. Lista reservation");
                Console.WriteLine("3. Registrera patient");
                Console.WriteLine("4. Registrera annställd");
                Console.WriteLine("5. Lista anställda");
                Console.WriteLine("6. Avsluta");

                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:

                        patient.RegisterVisit();

                        break;
                    case 2:

                        patient.ListBookings();

                        break;
                    case 3:

                        patient.RegisterPatient();

                        break;

                    case 4:

                        patient.RegisterDentist();

                        break;

                    case 5:
                        patient.ListWorkers();
                        break;

                    case 6:
                        shouldNotExit = false;
                        break;



                }

                Console.Clear();
            }
        }
    }
}
