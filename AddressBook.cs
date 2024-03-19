using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsInAddressBook
{
    public class AddressBook
    {
        public string firstName { get; set; }
        public string lastName  {  get; set; }
        public string address {  get; set; }
        public string city {  get; set; }
        public string state { get; set; }
        public string zipCode {  get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }

        public AddressBook(string first_name, string last_name, string Address, string City, string State, string zip, string phone, string Email)
        {
            firstName = first_name;
            lastName = last_name;
            address = Address;
            city = City;
            state = State;
            zipCode = zip;
            phone_number = phone;
            email = Email;
        }

        //public void setAddresBook(string first_name, string last_name, string Address, string City, string State, int zip, int phone, string Email)
        //{
        //    firstName = first_name;
        //    lastName = last_name;
        //    address = Address;
        //    city = City;
        //    state = State;
        //    zipCode = zip;
        //    phone_number = phone;
        //    email = Email;
        //}

        //public void getAddressBook()
        //{
        //    Console.WriteLine("First name : " + firstName);
        //    Console.WriteLine("Last name : " + lastName);
        //    Console.WriteLine("Address : " + address);
        //    Console.WriteLine("City : " + city);
        //    Console.WriteLine("State : " + state);
        //    Console.WriteLine("Zip Code : "+zipCode);
        //    Console.WriteLine("Phone number : "+phone_number);
        //    Console.WriteLine("Email : " + email);
        //}
    }
}