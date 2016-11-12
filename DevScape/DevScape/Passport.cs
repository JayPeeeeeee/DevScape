using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevScape
{
    class Passport
    {
        private string firstName;
        private string lastName;
        private Address address;
        private readonly DateTime dateOfBirth;
        private readonly Address birthAddress;
        private readonly Gender gender;
        private Nationality nationality;
        private readonly string nationalId;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public Address Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
                Nationality = MapNationality();
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
        }

        public Address BirthAddress
        {
            get
            {
                return birthAddress;
            }
        }

        public Gender Gender
        {
            get
            {
                return gender;
            }
        }

        public Nationality Nationality
        {
            get
            {
                return nationality;
            }
            private set
            {
                nationality = value;
            }
        }

        public string NationalId
        {
            get
            {
                return nationalId;
            }
        }

        public Passport(string firstName, string lastName, Address address, DateTime dateOfBirth, Address birthAddress, Gender gender, string nationalId)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            this.dateOfBirth = dateOfBirth;
            this.birthAddress = birthAddress;
            this.gender = gender;
            Nationality = MapNationality();
            this.nationalId = nationalId;
        }

        private Nationality MapNationality()
        {
            Nationality nationality;
            switch (Address.Country)
            {
                case Country.Belgium:
                    nationality = Nationality.Belgian;
                    break;
                case Country.GreatBritain:
                    nationality = Nationality.British;
                    break;
                case Country.France:
                    nationality = Nationality.French;
                    break;
                case Country.Germany:
                    nationality = Nationality.German;
                    break;
                case Country.Italy:
                    nationality = Nationality.Italian;
                    break;
                case Country.Spain:
                    nationality = Nationality.Spanish;
                    break;
                case Country.USA:
                    nationality = Nationality.American;
                    break;
                default:
                    nationality = Nationality.None;
                    break;
            }
            return nationality;
        }

        /*public void ChangeAddress(Address address)
        {
            //Address = address;
            //Nationality = MapNationality();
        }*/

        public override string ToString()
        {
            return string.Format("\tFirst Name: {0}\n\tLast Name: {1}\n\t*****Address:*****\n{2}\n\t**********\n\tDate of Birth: {3}\n\t*****Birth Address:*****\n{4}\n\t**********\n\tGender: {5}\n\tNationality: {6}\n\tNational Id: {7}",
                                 FirstName, LastName, Address, DateOfBirth, BirthAddress, Gender, Nationality, NationalId);
        }
    }
}
