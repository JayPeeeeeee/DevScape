using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevScape
{
    /**
     * To Do:
     * - Add checks with regex to validate the email, phone, fax and website
     * 
     * **/
    class ContactInfo
    {
        private string emailAddress;
        private string phoneNumber;
        private string faxNumber;
        private string website;

        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }
            set
            {
                if (value != "")
                {
                    emailAddress = value;
                }
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

        public string FaxNumber
        {
            get
            {
                return faxNumber;
            }
            set
            {
                faxNumber = value;
            }
        }

        public string Website
        {
            get
            {
                return website;
            }
            set
            {
                website = value;
            }
        }

        public ContactInfo(string emailAddress, string phoneNumber, string faxNumber, string website)
        {
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            FaxNumber = faxNumber;
            Website = website;
        }

        public override string ToString()
        {
            return string.Format("Email Address: {0}\nPhone Number: {1}\nFax Number: {2}\nWebsite: {3}",
                                 EmailAddress, PhoneNumber, FaxNumber, Website);
        }
    }
}
