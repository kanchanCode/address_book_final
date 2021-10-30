using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook
{
    public class Person
    {
        public string Addname { get; set; }
        public string name { get; set; }
        public string mobileNo { get; set; }
        public string address { get; set; }
        public string State { get; set; }

    }

    public class ContactDetails
    {
        public static LinkedList<Person> contactList = new LinkedList<Person>();
        public static Dictionary<string, Person> contactDict = new Dictionary<string, Person>();



        public static void AddPerson()
        {

            Person person = new Person();


            Console.WriteLine("Enter the addressbook name");
            person.Addname = Console.ReadLine();

            if (!contactDict.ContainsKey(person.Addname))
            {
                contactDict.Add(person.Addname, person);
            }
            else
            {
                Console.WriteLine("Address book alredy exist!!");
            }

            Console.Write("Enter name :");
            person.name = Console.ReadLine();

            Console.Write("Enter mobile number :");
            person.mobileNo = Console.ReadLine();

            Console.Write("Enter Address :");
            person.address = Console.ReadLine();

            Console.Write("Enter State :");
            person.State = Console.ReadLine();

            contactList.AddLast(person);

        }

        public static void PrintPerson(Person person)
        {
            Console.WriteLine("Address Book name:" + person.Addname);
            Console.WriteLine("Name: " + person.name);

            Console.WriteLine("Mobile Number: " + person.mobileNo);
            Console.WriteLine("Address : " + person.address);

            Console.WriteLine("-------------------------------------------");

        }

        public static void ListPeople()
        {
            if (contactList.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var person in contactList)
            {
                PrintPerson(person);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

        public static void DeletePerson()
        {
            Console.WriteLine("Enter the name of the person you would like to remove.");
            string name = Console.ReadLine();
            Person person = contactList.FirstOrDefault(x => x.name.ToLower() == name.ToLower());
            if (person == null)
            {
                Console.WriteLine("That person could not be found. Press any key to continue");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
            PrintPerson(person);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                contactList.Remove(person);
                Console.WriteLine("Person removed. Press any key to continue.");
                Console.ReadKey();
            }

        }

        public static void Editperson()
        {
            Console.WriteLine("Enter the name of the person you would like to edit.");
            string name = Console.ReadLine();
            Person person = contactList.FirstOrDefault(x => x.name.ToLower() == name.ToLower());
            if (person == null)
            {
                Console.WriteLine("That person could not be found. Press any key to continue");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Are you sure you want to edit this person from your address book? (Y/N)");
            PrintPerson(person);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                contactList.Remove(person);
                Console.WriteLine("enter new details");

                AddPerson();
            }

        }
    }
}



