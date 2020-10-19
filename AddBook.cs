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
        public bool CheckDuplicateName(string firstName)
        {

            if (collectionAddressBook.ContainsKey(firstName))
            {
                return false;
            }
            return true;
        }
        public string[] SearchByCity(string searchKey)
        {
            int countOfList = 0;
            string[] listOfSearchPersonsByCity = new string[] { };
            Dictionary<string, AddressBook>.Enumerator enumerator = collectionAddressBook.GetEnumerator();
            while (enumerator.MoveNext())
            {
                AddressBook searchAddressBook = enumerator.Current.Value;
                List<Contacts> listOfSearch = searchAddressBook.GetAddressBook();
                foreach (Contacts i in listOfSearch)
                {
                    if (i.City == searchKey)
                    {
                        listOfSearchPersonsByCity[countOfList++] = i.FirstName;
                    }
                }
                return listOfSearchPersonsByCity;
            }
             string[] SearchByState(string searchKey)
            {
                int countOfList = 0;
                string[] listOfSearchPersonsByState = new string[] { };
                Dictionary<string, AddressBook>.Enumerator enumerator = collectionAddressBook.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    AddressBook searchAddressBook = enumerator.Current.Value;
                    List<Contacts> listOfSearch = searchAddressBook.GetAddressBook();
                    foreach (Contacts i in listOfSearch)
                    {
                        if (i.City == searchKey)
                        {
                            listOfSearchPersonsByState[countOfList++] = i.FirstName;
                        }
                    }
                }
                return listOfSearchPersonsByState;
            }

        } } }


