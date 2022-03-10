using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Contact
    {
        public void AddContact()
        {
            string Name;
            Console.WriteLine("Enter FIRST name and LAST name");
            Name = Console.ReadLine();
            string Address;
            Console.WriteLine("Enter Address city state zip");
            Address = Console.ReadLine();
            string EmailId;
            Console.WriteLine("Enter EmailId");
            EmailId = Console.ReadLine();
            long Phonenumber;
            Console.WriteLine("Enter your PhoneNumber");
            Phonenumber = Convert.ToInt64(Console.ReadLine());
            
        }
    }
}
