internal class AddressBookMain
{
    // Current version supports just one address book
    public static AddressBook FirstAddressBook;

    static AddressBookMain()
    {
        // Max Size of the address book array is 10
        FirstAddressBook = new AddressBook(2);
    }
    static void Main(string[] args)
    {
        AddressBookMenu addressBookMenu = new AddressBookMenu();
        addressBookMenu.ShowMenu();
    }
}