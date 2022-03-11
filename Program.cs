using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem_Day9
{
    class Program
    {
        private static List<Contact> People = new List<Contact>();

        public static void Main(string[] args)
        {
            static void AddContact()
            {
                Console.WriteLine("Welcome to Address Book Program");

                Contact contact = new Contact();

                Console.WriteLine("Enter FIRST name ");
                contact.FirstName = Console.ReadLine();
                Console.WriteLine("Enter LAST name ");
                contact.LastName = Console.ReadLine();

                Console.WriteLine("Enter EmailId");
                contact.EmailId = Console.ReadLine();

                Console.WriteLine("Enter your PhoneNumber");
                contact.PhoneNumber = Console.ReadLine();

                Console.WriteLine("Enter Address1 city");
                string[] addresses = new string[2];
                addresses[0] = Console.ReadLine();
                Console.WriteLine("Enter Address2 state zipcode");
                addresses[1] = Console.ReadLine();
                contact.Address = addresses;
                
                People.Add(contact);    
            }
            static void DisplayContact(Contact contact)
            {
                Console.WriteLine("FirstName:" +contact.FirstName);
                Console.WriteLine("LastName:" + contact.LastName);
                Console.WriteLine("EmailId:" + contact.EmailId);
                Console.WriteLine("PhoneNumber:" + contact.PhoneNumber);
                Console.WriteLine("Address 1:" + contact.Address[0]);
                Console.WriteLine("Address 2:" + contact.Address[1]);
                Console.WriteLine("--------------------------------");
            }
        }
    }
}