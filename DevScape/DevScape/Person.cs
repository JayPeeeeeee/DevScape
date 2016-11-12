using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevScape
{
    /**
     * To Do:
     * - 
     * - 
     * 
     * 
     * **/
    class Person
    {
        private Passport passport;
        private ContactInfo contactInfo;
        private decimal savings;

        public Passport Passport
        {
            get
            {
                return passport;
            }
            set
            {
                passport = value;
            }
        }

        public ContactInfo ContactInfo
        {
            get
            {
                return contactInfo;
            }
            set
            {
                contactInfo = value;
            }
        }

        public decimal Savings
        {
            get
            {
                return savings;
            }
            private set
            {
                savings = value;
            }
        }

        public Person(Passport passport, ContactInfo contactInfo, decimal savings)
        {
            Passport = passport;
            ContactInfo = contactInfo;
            Savings = savings;
        }

        public override string ToString()
        {
            return string.Format("\t***************Passport:***************\n{0}\n\t******************************\n***********Contact Information:**********\n{1}\n********************\nSavings: {2} Euro", Passport, ContactInfo, Savings);
        }
    }
}
