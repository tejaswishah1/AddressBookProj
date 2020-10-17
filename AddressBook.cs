using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProject
{
    public class AddressBook : Contacts
    {
      public  Dictionary<string, Contacts> addressBook = new Dictionary<string, Contacts>();

        public void AddContact(string fname, string lname, string address, string phone, string state, string city, string email)
        {
            Contacts contact = new Contacts();
            contact.FirstName = fname;
            contact.LastName = lname;
            contact.Address = address;
            contact.PhoneNuber = phone;
            contact.State = state;
            contact.City = city;
            contact.Email = email;

            addressBook.Add(contact.FirstName, contact);
        }

        public void ViewData()
        {
            foreach(KeyValuePair<string, Contacts> i in addressBook)
                {
                Console.WriteLine("First name is " +i.Value.FirstName);
                Console.WriteLine("Last name is " + i.Value.LastName);
                Console.WriteLine("Address is " + i.Value.Address);
                Console.WriteLine("Phone number is " + i.Value.PhoneNuber);
                Console.WriteLine("State is " + i.Value.State);
                Console.WriteLine("City is " + i.Value.City);
                Console.WriteLine("Email ID is " + i.Value.Email);

            }
        }
    }
}
