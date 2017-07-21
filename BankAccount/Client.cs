using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        protected string firstName;
        protected string lastName;
        protected string address;
        protected string phoneNumber;

        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string Address { get; set; }
        //public string PhoneNumber { get; set; }

        public Client()
        {
            //default constructor
        }    
        public Client(string firstName, string lastName, string address, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }
        public void GetClientInfo()
        {
            Console.WriteLine("Customer first name is " + firstName);
            Console.WriteLine("Customer last name is " + lastName);
            Console.WriteLine("Customer address is " + address);
            Console.WriteLine("Customer phone number is " + phoneNumber);
        }
    }
}
