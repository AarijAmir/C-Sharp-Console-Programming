using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.aggregation
{
    class Address
    {
        private String street;
        private String city;
        private String stateProvince;
        private String country;

        public Address()
        {
        }

        public Address(string street, string city, string stateProvince, string country)
        {
            this.street = street;
            this.city = city;
            this.stateProvince = stateProvince;
            this.country = country;
        }

        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string StateProvince { get => stateProvince; set => stateProvince = value; }
        public string Country { get => country; set => country = value; }

        public void Print()
        {
            Console.WriteLine("Street: " + this.street + " City:" + this.city + " State: " + this.stateProvince + " Country: " + this.country);
        }
        public String GetStringAddress() => this.street + " - " + this.City + " - " + this.stateProvince + " - " + this.country;
    }
}
