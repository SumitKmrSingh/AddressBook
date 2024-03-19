// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ContactsInAddressBook;

class MainCalss
{
    static AddressBook addressBook;
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Add Contact ");
            Console.WriteLine("2. Display Contact ");
            Console.WriteLine("3. Edit Contact ");
            Console.WriteLine("4. Delete Contact ");

            Console.Write("Enter Your Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                        // Creating object of ContactPerson Class
                        ContactPerson person = new ContactPerson();
                        addressBook = person.getPersonInformation();
                        break;

                case 2:
                        ContactPerson display = new ContactPerson();
                        display.displayContactInfo(addressBook);
                        break;
            }
        }

        // Creating object of AddressBook Class
        //AddressBook addressBook = new AddressBook();
    }
}
