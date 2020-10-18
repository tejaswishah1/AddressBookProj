using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProject
{
    public class AddressBook : IContacts
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
        public void ViewData(string name)
        {
            foreach (KeyValuePair<string, Contacts> i in addressBook)
            {
                if (i.Key.Equals(name))
                {
                    Console.WriteLine("First name is " + i.Value.FirstName);
                    Console.WriteLine("Last name is " + i.Value.LastName);
                    Console.WriteLine("Address is " + i.Value.Address);
                    Console.WriteLine("Phone number is " + i.Value.PhoneNuber);
                    Console.WriteLine("State is " + i.Value.State);
                    Console.WriteLine("City is " + i.Value.City);
                    Console.WriteLine("Email ID is " + i.Value.Email);
                }

            }
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
        public void EditContact(string name)
        {
            foreach(KeyValuePair<string, Contacts> i in addressBook)
            {
                if (i.Key.Equals(name))
                {
                    Console.WriteLine("Enter 1 to change First Name");
                    Console.WriteLine("Enter 2 to change Last Name");
                    Console.WriteLine("Enter 3 to change Address");
                    Console.WriteLine("Enter 4 to change Phone Number");
                    Console.WriteLine("Enter 5 to change State");
                    Console.WriteLine("Enter 6 to change City");
                    Console.WriteLine("Enter 7 to change Email");

                    int choiceOfUser;
                    choiceOfUser = Convert.ToInt32(Console.ReadLine());

                    switch (choiceOfUser)
                    {
                        case 1:
                            Console.WriteLine("Enter the first name: ");
                            i.Value.FirstName = Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("Enter the last name: ");
                            i.Value.LastName = Console.ReadLine();
                            break;

                        case 3:
                            Console.WriteLine("Enter Address: ");
                            i.Value.Address = Console.ReadLine();
                            break;

                        case 4:
                            Console.WriteLine("Enter phone number: ");
                            i.Value.PhoneNuber = Console.ReadLine();
                            break;

                        case 5:
                            Console.WriteLine("Enter state: ");
                            i.Value.State = Console.ReadLine();
                            break;

                        case 6:
                            Console.WriteLine("Enter city: ");
                            i.Value.City = Console.ReadLine();
                            break;

                        case 7:
                            Console.WriteLine("Enter Email ID: ");
                            i.Value.Email = Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine(" Try again");
                    

                
                }
            }
        }
        public void DeleteContact(string name)
        {
            if (addressBook.ContainsKey(name))
            {
                addressBook.Remove(name);
                Console.WriteLine("Deleted successfully");

            }
            else
            {
                Console.WriteLine("Invalid choice. Try again");
            }
        }
    }
}
