using System;
using System.Collections.Generic;

namespace AddressBook.Models
{
    public class Contact
    {
        private string _name;
        private string _phoneNumber;
        private Address _address;
        private bool _new = true;
        private int _id;

        private static List<Contact> _instances = new List<Contact>{};

        public Contact (string name, string phoneNumber, Address address)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _address = address;
            _instances.Add(this);
            _id = _instances.Count;
        }

        public string GetContactName()
        {
            return _name;
        }
        public void SetContactName(string newName)
        {
            _name = newName;
        }

        public string GetPhone()
        {
            return _phoneNumber;
        }
        public void SetPhone(string newPhoneNumber)
        {
            _phoneNumber = newPhoneNumber;
        }

        public Address GetAddress()
        {
            return _address;
        }

        public void SetAddress(Address newAddress)
        {
            _address = newAddress;
        }

        public bool GetNewStatus()
        {
            return _new;
        }

        public void ChangeNewStatus()
        {
            _new = false;
        }

        public int GetId()
        {
            return _id;
        }

        public static List<Contact> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Contact Find(int searchId)
        {
            return _instances[searchId-1];
        }

        public static void RemoveContact(int id)
        {
            _instances.RemoveAt(id-1);
            for (int changeIdIndex = id -1; changeIdIndex < _instances.Count; changeIdIndex++)
            {
                _instances[changeIdIndex]._id = _instances[changeIdIndex]._id - 1;
            }

        }

        public static List<Contact> SearchContacts(List<Contact> contacts, string searchInput)
        {
            string upperInput = searchInput.ToUpper();
            List<Contact> searchMatch = new List<Contact> {};
            foreach (Contact contact in _instances)
            {
                string upperContactName = contact.GetContactName().ToUpper();
                if(upperContactName.Contains(upperInput) == true)
                searchMatch.Add(contact);
            }

            // Regex regex = new RegEx($@"{searchInput}", RegexOptions.IgnoreCase);
            // List<Contact> searchMatch = new List<Contact> {};
            // foreach(Contact contact in contacts)
            // {
            //     Match contactMatch = regex.Match(contact.GetContactName());
            //     if (match.Success)
            //     {
            //         searchMatch.Add(contact);
            //     }
            // }
            return searchMatch;
        }

    }
}
