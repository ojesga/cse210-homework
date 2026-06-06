using System;

namespace OnlineOrdering
{
    public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        // Method calls down into the encapsulated Address object to verify location
        public bool LivesInUsa()
        {
            return _address.IsInUsa();
        }

        // Public getters for Order to generate the labels safely
        public string GetName()
        {
            return _name;
        }

        public Address GetAddress()
        {
            return _address;
        }
    }
}