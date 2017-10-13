using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AddressBook.Models
{
    public class Contact
    {
        private string _name;
        private string _phoneNumber;
        // private string _address;
        private Address _address;
        private bool _new = true;
        private int _id;

        private static List<Contact> _instances = new List<Contact>{};

        //string address put this back into the parends
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

        // public string GetAddress()
        // {
        //     return _address;
        // }
        // public void SetAddress(string newAddress)
        // {
        //     _address = newAddress;
        // }

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

        public static void SearchContacts(List<Contact> contacts, string searchInput)
        {
            string upperInput = searchInput.ToUpper();
            char[] splitUpperInput = upperInput.ToCharArray();
            List<char> searchList = new List<char>{};
            int limit = splitUpperInput.Length;
            if (limit > 3)
            {
                limit = 3;
            }
            for (int index = 0; index < limit; index++)
            {
                searchList.Add(splitUpperInput[index]);
                Console.WriteLine(splitUpperInput[index]);
            }
            foreach (Contact contact in _instances)
            {
                if()
            }

            // listStrLineElements = line.Split(',').ToList();
            // List<Contact> searchMatch = new List<Contact> {};
            // foreach(Contact contact in contacts)
            // {
            //     Match contactMatch = regex.Match(contact.GetContactName());
            //     if (match.Success)
            //     {
            //         searchMatch.Add(contact);
            //     }
            // }
            // return searchMatch;
            //
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
            // return searchMatch;
        }

    }
}
