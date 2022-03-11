using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem_Day9
{
    public class Contact
    {
        public string FirstName { get; set; } //string property for first ,second name , phone number
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public string[] Address { get; set; } //string array to hold two addresses
    }
}
