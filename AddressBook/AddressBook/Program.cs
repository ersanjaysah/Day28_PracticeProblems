using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Problem ");
            AddressBook manager = new AddressBook();

            //Infinite Loop
            while (true)
            {
                Console.WriteLine("\nPlease Select any one option: ");
                Console.WriteLine("1: To add Details to Address Book");
                Console.WriteLine("2: To Display All Contacts of Address Book");
                int read = int.Parse(Console.ReadLine());
                switch (read)
                {
                    //For Adding Details to Address Book
                    case 1:
                        {
                            Person person = new Person();
                            Console.WriteLine("Enter First Name: ");
                            string fname = Console.ReadLine();
                            person.FName = fname;
                            Console.WriteLine("Enter Last Name: ");
                            string lname = Console.ReadLine();
                            person.LName = lname;
                            Console.WriteLine("Enter Address: ");
                            string address = Console.ReadLine();
                            person.Address = address;
                            Console.WriteLine("Enter Phone Number: ");
                            long number = long.Parse(Console.ReadLine());
                            person.PhoneNumber = number;
                            manager.addPerson(person);
                        }
                        break;
                    //Display contact list of addressbook
                    case 2:
                        {
                            manager.Display();
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Please Select any one operation ");
                        }
                        break;
                }
            }

        }
    }
}
