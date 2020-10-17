using System;

namespace AddressBookProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book \n");
 
            AddressBook addressbook = new AddressBook();
            addressbook.AddContact("Amit", "Agarwal", "Newton. Plot 34/7", "9163121771","West Bengal", "Kolkata", "amit@gmail.com");
            addressbook.ViewData();
        }
    }
}
