using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_lab
{
    class Address
    {
        public string country;
        public string city;
        public string street;


        public string Country { get { return country; } set { country = value; } }
        public string City { get { return city; } set { city = value; } }
        public string Street { get { return street; } set { street = value; } }


        public Address(string Country, string City, string Street)
        {
            country = Country;
            city = City;
            street = Street;
        }
    }
}
