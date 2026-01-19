internal class Program
{
    private static List<Contact> contacts;
    private static string adminId = "admin";
    private static string adminPassword = "admin";

    static Program(){
        contacts = new List<Contact>();
    }

    public static void Main(string[] args)
    {
        StartApplication();
    }

    private static void StartApplication()
    {
        Console.WriteLine("\n==== Welcome to Contact Management ====\n");
        if (AuthenticateAdmin())
        {
            while (true)
            {
                Console.WriteLine("1. Add a contact");
                Console.WriteLine("2. Delete a contact");
                Console.WriteLine("3. Update a contact");
                Console.WriteLine("4. Display all contacts");
                Console.WriteLine("5. Search for a contact");
                Console.WriteLine("6. Exit");
                Console.Write("Please enter your choice: ");
                int userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        AddContact();
                        break;
                    case 2:
                        DeleteContact();
                        break;
                    case 3:
                        UpdateContact();
                        break;
                    case 4:
                        DisplayAllContacts();
                        break;
                    case 5:
                        Search();
                        break;
                    case 6:
                        return;
                }
            }
        }
    }

    private static void Search()
    {
        Console.WriteLine("\n=== Search Manager ===\n");
        Console.Write("Enter your search query: ");
        string searchQuery = Console.ReadLine();

        foreach(Contact contact in contacts)
        {
            if(contact.GetEmailId().StartsWith(searchQuery) || contact.GetContactName().StartsWith(searchQuery) || contact.GetPhoneNumber().StartsWith(searchQuery) || contact.GetContactCity().StartsWith(searchQuery))
            {
                Console.WriteLine(contact);
            }
        }
    }
    private static void DisplayAllContacts()
    {
        Console.WriteLine("\n=== All Contacts ===\n");
        foreach(Contact contact in contacts)
        {
            Console.WriteLine(contact);
        }
    }

    private static void AddContact()
    {
        Console.WriteLine("\n==== Contact Adding Window ====\n");
        Console.Write("Please enter contact name: ");
        string name = Console.ReadLine();
        Console.Write("Please enter contact email: ");
        string email = Console.ReadLine();
        Console.Write("Please enter phone number: ");
        string phoneNumer = Console.ReadLine();
        Console.Write("Please enter contact city: ");
        string contactCity = Console.ReadLine();

        Contact contact = new Contact(name, email, phoneNumer, contactCity);
        contacts.Add(contact);
        Console.WriteLine("Contact added successfully...");
    }

    private static void DeleteContact()
    {
        Console.WriteLine("\n==== Contact Deletion Window ====\n");
        Console.Write("Please enter the email id of the contact to be deleted: ");
        string emailId = Console.ReadLine();

        // Finding the contact in the contacts list
        int i = 0;
        for(; i < contacts.Count; i++)
        {
            if (contacts.ElementAt(i).GetEmailId().Equals(emailId))
            {
                break;
            }
        }

        if(i < contacts.Count && contacts.ElementAt(i).GetEmailId().Equals(emailId))
        {
            contacts.RemoveAt(i);
            Console.WriteLine("Contact Removed Successfully.");
        }
    }

    private static void UpdateContact()
    {
        Console.WriteLine("\n==== Contact Updation Window ====\n");
        Console.Write("Please enter the email id of the contact to be updated: ");
        string emailId = Console.ReadLine();
        Console.WriteLine("Please choose what to update ");
        Console.WriteLine("1. Update Contact Name");
        Console.WriteLine("2. Update Contact Email");
        Console.WriteLine("3. Update Contact Phone number");
        Console.Write("Please enter your choice: ");
        int userChoice = int.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                Console.Write("Enter new name: ");
                string updatedName = Console.ReadLine();
                UpdateWithName(updatedName, emailId);
                break;
            case 2:
                Console.Write("Enter new email: ");
                string updatedEmail = Console.ReadLine();
                UpdateWithEmail(updatedEmail, emailId);
                break;
            case 3:
                Console.Write("Enter new phone number: ");
                string phoneNumber = Console.ReadLine();
                UpdateWithPhoneNumber(phoneNumber, emailId);
                break;
        }
    }

    private static void UpdateWithName(string updatedName, string emailId)
    {
        for(int i = 0; i < contacts.Count; i++)
        {
            if (contacts.ElementAt(i).GetEmailId().Equals(emailId))
            {
                contacts.ElementAt(i).SetContactName(updatedName);
                break;
            }
        }
    }
    private static void UpdateWithEmail(string updatedEmail, string emailId)
    {
        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts.ElementAt(i).GetEmailId().Equals(emailId))
            {
                contacts.ElementAt(i).SetEmailId(updatedEmail);
                break;
            }
        }
    }

    private static void UpdateWithPhoneNumber(string updatedPhone, string emailId)
    {
        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts.ElementAt(i).GetEmailId().Equals(emailId))
            {
                contacts.ElementAt(i).SetPhoneNumber(updatedPhone);
                break;
            }
        }
    }
    private static bool AuthenticateAdmin()
    {
        Console.WriteLine("\n==== Admin Authentication Window ====\n");
        Console.Write("Please enter your admin id: ");
        string id = Console.ReadLine();
        Console.Write("Please enter your admin password: ");
        string password = Console.ReadLine();

        if(adminId.Equals(id) && adminPassword.Equals(password))
        {
            Console.WriteLine("Authentication Successfull...");
            return true;
        }
        Console.WriteLine("Authentication Failed...");
        return false;
    }
}