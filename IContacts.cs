using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProject
{
    interface IContacts
    {
        public void AddContact(string fname, string lname, string address, string phone, string state, string city, string email);
        public void EditContact(string name);
    }
}
