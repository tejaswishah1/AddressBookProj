using System;

namespace AddressBookProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book \n");
 
            AddressBook addressbook = new AddressBook();
            

           
           ////Collect data from user:
            Console.WriteLine("Enter First Name :");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name :");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter Address :");
            string address = Console.ReadLine();

            Console.WriteLine("Enter phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter State :");
            string state = Console.ReadLine();

            Console.WriteLine("Enter City :");
            string city = Console.ReadLine();

            Console.WriteLine("Enter Email :");
            string email = Console.ReadLine();

            Console.WriteLine(Environment.NewLine);

            addressbook.AddContact(firstName,lastName,address,phoneNumber,state,city,email);
            addressbook.ViewData();

            addressbook.EditContact(firstName);
            addressbook.ViewData();



        }
    }
}
