internal class AddressBookMenu
{
    private AddressBookUtility addressBookUtility;

    public AddressBookMenu()
    {
        addressBookUtility = new AddressBookUtility();
    }

    public void ShowMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\n==== Welcome to Address Book ====\n");
            Console.WriteLine("1. Add a Contact");
            Console.WriteLine("2. Display all Contacts");
            Console.WriteLine("0. Exit");
            Console.Write("Please enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    addressBookUtility.AddContact();
                    break;
                case 2:
                    addressBookUtility.DisplayAllContacts();
                    break;
            }

        } while (choice != 0);
    }
}