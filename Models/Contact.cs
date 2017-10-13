using System.Collections.Generic;

namespace AddressBook.Models
{
    public class Contact
    {
        private string _name;
        private string _phoneNumber;
        private string _address;
        private bool _new = true;
        private int _id;

        private static List<Contact> _instances = new List<Contact>{};

        public Contact (string name, string phoneNumber, string address)
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

        public string GetAddress()
        {
            return _address;
        }
        public void SetAddress(string newAddress)
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
        }

    }
}
