using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevScape
{
    class Address
    {
        private string street;
        private string streetNumber;
        private string zipCode;
        private string city;
        private Country country;
        private Continent continent;

        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }

        public string StreetNumber
        {
            get
            {
                return streetNumber;
            }
            set
            {
                streetNumber = value;
            }
        }

        public string ZipCode
        {
            get
            {
                return zipCode;
            }
            set
            {
                zipCode = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public Country Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        public Continent Continent
        {
            get
            {
                return continent;
            }
            set
            {
                continent = value;
            }
        }

        public Address(string street, string streetNumber, string zipCode, string city, Country country, Continent continent)
        {
            Street = street;
            StreetNumber = streetNumber;
            ZipCode = zipCode;
            City = city;
            Country = country;
            Continent = continent;
        }

        public override string ToString()
        {
            return string.Format("\tStreet: {0}\n\tStreet Number: {1}\n\tZip Code: {2}\n\tCity: {3}\n\tCountry: {4}\n\tContinent: {5}",
                                 Street, StreetNumber, ZipCode, City, Country, Continent);
        }
    }
}
