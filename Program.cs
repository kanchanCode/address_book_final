using System;

namespace AddressBook
{
    class Start
    {
       
        static void Main(string[] args)
        {
            string command ="";
            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("1. To add new Details of Person");
            Console.WriteLine("2. To delete Details of Person using name");
            Console.WriteLine("3. To list the Details of Person");
            Console.WriteLine("4. To edit Details of Person using name");
            Console.WriteLine("5. To exit");

            while (command != "5")
            {

                Console.WriteLine("Enter your choice");

                    command = Console.ReadLine();
           

                switch (command)
                {
                    case "1":

                        Console.Clear();
                        /*Console.WriteLine("Enter the name of the address book");
                        string addbook = Console.ReadLine();*/

                       
                        Console.WriteLine("How many contacts you want to add");
                        int n = Convert.ToInt32(Console.ReadLine());
                      
                        for (int i = 1; i <= n; i++)
                        {
                            Console.WriteLine("PERSON : " + i);
                            ContactDetails.AddPerson();
                            
                          
                        }
                        Console.WriteLine("Press 1 to add, 2 to remove , 3 to list all , 4 to edit and 5 to exit ");
                        break;
                    case "2":
                        Console.Clear();
                        ContactDetails.DeletePerson();
                        Console.WriteLine("Press 1 to add, 2 to remove , 3 to list all , 4 to edit and 5 to exit ");
                        break;
                    case "3":
                        Console.Clear();
                        ContactDetails.ListPeople();
                        Console.WriteLine("Press 1 to add, 2 to remove , 3 to list all , 4 to edit and 5 to exit ");
                        break;
                    case "4":
                        Console.Clear();
                        ContactDetails.Editperson();
                        Console.WriteLine("Press 1 to add, 2 to remove , 3 to list all , 4 to edit and 5 to exit ");
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;

                }
            }
        }


        
    }
}
