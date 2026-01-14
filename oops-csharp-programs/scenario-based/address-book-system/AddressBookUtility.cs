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
}