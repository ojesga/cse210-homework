using System;

namespace OnlineOrdering
{
    public class Address
    {
        private string _streetAddress;
        private string _city;
        private string _stateOrProvince;
        private string _country;

        public Address(string streetAddress, string city, string stateOrProvince, string country)
        {
            _streetAddress = streetAddress;
            _city = city;
            _stateOrProvince = stateOrProvince;
            _country = country;
        }

        // Returns true if the country is USA (handles case variations)
        public bool IsInUsa()
        {
            return _country.ToLower() == "usa" || _country.ToLower() == "united states";
        }

        // Formats the entire address beautifully into a single block string with line breaks
        public string GetFullAddressString()
        {
            return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
        }
    }
}