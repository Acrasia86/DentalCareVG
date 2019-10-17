using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestarTentan
{
    class Patient
    {
        Menu menu = new Menu();

        Dictionary<string, RegisterHuman> patientDictionary = new Dictionary<string, RegisterHuman>();
        Dictionary<string, Reservation> reservationDictionary = new Dictionary<string, Reservation>();
        Dictionary<string, Dentist> dentistDictionary = new Dictionary<string, Dentist>();
        Dictionary<string, Dentalhygenisist> dentalhDictionary = new Dictionary<string, Dentalhygenisist>(); 

        
        public void RegisterPatient()
        {
            Console.Clear();

            Console.Write("First name: ");

            string firstName = Console.ReadLine();

            Console.Write("Last name: ");

            string lastName = Console.ReadLine();

            Console.Write("Social security number: ");

            string socialSecurityNumber = Console.ReadLine();

            Console.Write("Phone number: ");

            string phoneNumber = Console.ReadLine();

            Console.Write("Email: ");

            string email = Console.ReadLine();

            
                Console.WriteLine("\n\nIs this correct? (Y)es (N)o");

                ConsoleKeyInfo userInput = Console.ReadKey(true);
            
            Console.Clear();

            bool hasValidInput = false;

            do
            {
                switch (userInput.Key)
                {


                    case ConsoleKey.Y:

                        if (patientDictionary.ContainsKey(socialSecurityNumber))
                        {

                            Console.WriteLine("Patient already registered");
                            Thread.Sleep(1200);
                            hasValidInput = true;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Patient registered");
                            Thread.Sleep(1200);
                            RegisterHuman registerPatient = new RegisterHuman(firstName, lastName, socialSecurityNumber, phoneNumber, email);
                            patientDictionary.Add(socialSecurityNumber, registerPatient);
                            hasValidInput = true;

                            break;
                        }

                    case ConsoleKey.N:

                        menu.Menus();

                        break;


                }
            } while (hasValidInput == false);
        }

        public void RegisterVisit()
        {
            Console.Clear();

            Console.Write("Patient social security number: ");

            string patientSocialSecurityNumber = Console.ReadLine();

            Console.Write("Reason for visist: ");

            string reasonForVisit = Console.ReadLine();

            Console.Write("Dentist: ");

            string dentist = Console.ReadLine();

            Console.Write("Date: ");

            DateTime date = DateTime.Parse(Console.ReadLine());


            Console.WriteLine("\n\nIs this correct? (Y)es (N)o ");

            ConsoleKeyInfo input = Console.ReadKey(true);

            Console.Clear();

            if (patientDictionary.ContainsKey(patientSocialSecurityNumber) && dentistDictionary.ContainsKey(dentist))
            {
                Console.WriteLine("Visist registered");
                Thread.Sleep(1200);
                Reservation reservation = new Reservation(patientSocialSecurityNumber, reasonForVisit, dentist, date);
                reservationDictionary.Add(patientSocialSecurityNumber, reservation);
                
               
            }

            else if(patientDictionary.ContainsKey(patientSocialSecurityNumber))
            {
                Console.WriteLine("Dentist not found");
            }

            else
            {

                Console.WriteLine("Patient not found");
                Thread.Sleep(1200);


            }
            Console.ReadLine();
        }

        public void RegisterDentist()
        {
            Console.Clear();

            Console.Write("First name: ");

            string firstName = Console.ReadLine();

            Console.Write("Last name: ");

            string lastName = Console.ReadLine();

            Console.Write("Social security number: ");

            string socialSecurityNumber = Console.ReadLine();

            Console.Write("Phone number: ");

            string phoneNumber = Console.ReadLine();

            Console.Write("Email: ");

            string email = Console.ReadLine();

            Console.Write("Id: ");

            string id = Console.ReadLine();

            Console.Write("Salary: ");

            int salary = int.Parse(Console.ReadLine());

            Console.Write("\n(1) Dentist      (2) Dental hygenisist");

            Console.Write("\nRoll: ");

            string choise = Console.ReadLine();

            
            Console.WriteLine("\n\nIs this correct? (Y)es (N)o");

            ConsoleKeyInfo input = Console.ReadKey(true);

            Console.Clear();

            if (dentistDictionary.ContainsKey(id) && input.Key == ConsoleKey.Y && choise == "1")
            {

                Console.WriteLine("Dentist already registered");
                Thread.Sleep(1200);

            }

            else if (input.Key == ConsoleKey.N)
            {
                menu.Menus();
            }

            else if(choise == "1")
            {

                Console.WriteLine("Dentist registered");
                Thread.Sleep(1200);
                Dentist dentist = new Dentist(firstName, lastName, socialSecurityNumber, phoneNumber, email, id, salary);
                dentistDictionary.Add(id, dentist);

               
            }
            else if(choise == "2" && dentalhDictionary.ContainsKey(id))
            {
                Console.WriteLine("Dental hygenisist already registered");
                Thread.Sleep(1200);
            }

            else if(choise == "2")
            {
                Console.WriteLine("Dental hygenisist registered");
                Dentalhygenisist dentalHygenisist = new Dentalhygenisist(firstName, lastName, socialSecurityNumber, phoneNumber, email, id, salary);
                dentalhDictionary.Add(id, dentalHygenisist);
                Thread.Sleep(1200);

            }

        }

        public void ListBookings()
        {
            Console.Clear();

            Console.WriteLine("Patient                           Reason                           Date ");
            Console.WriteLine("---------------------------------------------------------------------------");
            foreach (var booking in reservationDictionary)
            {
                foreach (var item in patientDictionary)
                {
                    Console.WriteLine($"{item.Value.FirstName} {item.Value.LastName}, {item.Value.SocialSecurityNumber}              {booking.Value.ReasonForVisit}                 {booking.Value.Date}");
                }
                
            }

            Console.ReadLine();
        }

        public void ListWorkers()
        {
            Console.Clear();

            Console.WriteLine("Employee                                                    Id"      );
            Console.WriteLine("---------------------------------------------------------------------");

            foreach (var dentist in dentistDictionary)
            {
                Console.WriteLine($"{dentist.Value.FirstName} {dentist.Value.LastName}, {dentist.Value.DentistMessage()}                                          {dentist.Value.Id}");
                foreach (var dental in dentalhDictionary)
                {
                    Console.WriteLine($"{dental.Value.FirstName} {dental.Value.LastName}, {dental.Value.DentalHMessage()}                                   {dental.Value.Id}");
                }
                
            }

            Console.ReadLine();

        }

        public void DeleteWorker()
        {
            Console.Clear();
            Console.Write("What id would you like to remove: ");

            string id = Console.ReadLine();

            dentistDictionary.Remove(id);

        }



        }

        
    }

