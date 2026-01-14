internal class AddressBookUtility: IAddressBook
{
    private AddressBook FirstAddressBook;
    private Contact[] Contacts;
    private int AddressBookMaxSize;
    private int AddressBookIndex;

    public AddressBookUtility()
    {
        FirstAddressBook = AddressBookMain.FirstAddressBook;
        AddressBookMaxSize = AddressBookMain.FirstAddressBook.GetMaxSize();
        AddressBookIndex = AddressBookMain.FirstAddressBook.GetCurrentIndex();
        Contacts = AddressBookMain.FirstAddressBook.GetContacts();
    }
    public void AddContact()
    {
        Console.WriteLine("\n==== Contact Adding Window ====\n");
        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter city name: ");
        string city = Console.ReadLine();
        Console.Write("Enter state name: ");
        string state = Console.ReadLine();
        Console.Write("Enter Zip code: ");
        string zipCode = Console.ReadLine();
        Console.Write("Enter Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        Contact newContact = new Contact(firstName, lastName, city, state, zipCode, phoneNumber, email);

        if(AddressBookIndex < AddressBookMaxSize)
        {
            // Updating Contacts array here also updates the Contacts array in the state as this is reference type
            Contacts[AddressBookIndex++] = newContact;
            // Since AddressBookIndex is int, to update the state, we'll have to call the setter method
            FirstAddressBook.SetCurrentIndex(AddressBookIndex);
            Console.WriteLine("\nContact added successfully.\n");
        }
        else
        {
            Console.WriteLine("\nContact array is full.\n");
        }
    }
    
    public void DisplayAllContacts()
    {
        if(AddressBookIndex == 0)
        {
            Console.WriteLine("\nThere are NO contacts in the address book...\n");
            return;
        }
        Console.WriteLine("\nHere are all the contacts:\n");
        for(int i = 0; i < AddressBookIndex; i++)
        {
            Console.WriteLine(Contacts[i]);
        }
        Console.WriteLine("\n");
    }

    public void EditExistingContact()
    {
        if(AddressBookIndex == 0)
        {
            Console.WriteLine("\nThere are NO contacts in the address book...\n");
            return;
        }
        Console.WriteLine("\n==== Editing Existing Contact Window ====\n");
        Console.Write("Enter contact first name: ");
        string name = Console.ReadLine();
        Contact contact = FindContactByName(name);

        if(contact == null)
        {
            Console.WriteLine("\nContact with this first name doesn't exist\n");
            return;
        }

        Console.WriteLine("1. Edit first name.");
        Console.WriteLine("2. Edit last name.");
        Console.WriteLine("3. Edit city name.");
        Console.WriteLine("4. Edit state name.");
        Console.WriteLine("5. Edit zip code.");
        Console.WriteLine("6. Edit phone number.");
        Console.WriteLine("7. Edit Email.");
        Console.WriteLine("0. Cancel Edit");
        Console.Write("\nPlease enter your choice: ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");

        switch (choice)
        {
            case 1:
                Console.Write("Please enter updated first name: ");
                string firstName = Console.ReadLine();
                contact.SetFirstName(firstName);
                break;
            case 2:
                Console.Write("Please enter updated last name: ");
                string lastName = Console.ReadLine();
                contact.SetLastName(lastName);
                break;
            case 3:
                Console.Write("Please enter updated city name: ");
                string cityName = Console.ReadLine();
                contact.SetCity(cityName);
                break;
            case 4:
                Console.Write("Please enter updated state name: ");
                string stateName = Console.ReadLine();
                contact.SetState(stateName);
                break;
            case 5:
                Console.Write("Please enter updated zip code: ");
                string zipCode = Console.ReadLine();
                contact.SetZipCode(zipCode);
                break;
            case 6:
                Console.Write("Please enter updated phone number: ");
                string phoneNumber = Console.ReadLine();
                contact.SetPhoneNumber(phoneNumber);
                break;
            case 7:
                Console.Write("Please enter updated email: ");
                string email = Console.ReadLine();
                contact.SetEmail(email);
                break;
            case 0:
                return;
        }

        Console.WriteLine("\nContact Updated Successfully...\n");
    }

    // Helper method for EditExistingContact method to find a contact given its name
    // Returns the contact if the contact is found in the array
    // Returns null otherwise
    private Contact FindContactByName(string name)
    {
        for(int i = 0; i < AddressBookIndex; i++)
        {
            if (Contacts[i].GetFirstName().Equals(name)) return Contacts[i];
        }

        return null;
    }
}