using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace AddressBookProject
{
    public class AddBook
    {
        Dictionary<string, AddressBook> collectionAddressBook = new Dictionary<string, AddressBook>();
        public void AddAddressBook(string firstName)
        {
            AddressBook newAddressBook = new AddressBook();
            collectionAddressBook.Add(firstName, newAddressBook);
        }
        public AddressBook GetAddressBook(string firstName)
        {
            if (collectionAddressBook.ContainsKey(firstName))
            {
                return collectionAddressBook[firstName];
            }
            return null;
        }
        public bool CheckDuplicateName (string firstName)
        {
            if(collectionAddressBook.ContainsKey(firstName))
            {
                return false;
            }
            return true;
        }
    }

}
