using System.Collections.Generic;

namespace AddressBook.Models
{
    public class Address
    {
        private string _street;
        private string _city;
        private string _state;
        private string _zip;

        private static List<Address> _addressInstances = new List<Address>{};

        public Address(string street, string city, string state, string zip)
        {
            _street = street;
            _city = city;
            _state = state;
            _zip = zip;
        }

        public string GetStreet()
        {
            return _street;
        }
        public void SetStreet(string street)
        {
            _street = street;
        }

        public string GetCity()
        {
            return _city;
        }
        public void SetCity(string city)
        {
            _city = city;
        }

        public string GetState()
        {
            return _state;
        }
        public void SetState(string state)
        {
            _state = state;
        }

        public string GetZip()
        {
            return _zip;
        }
        public void SetZip(string zip)
        {
            _zip = zip;
        }
    }
}
