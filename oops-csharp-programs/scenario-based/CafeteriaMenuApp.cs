using System;

class MenuItem
{
    private string menuItemName;
    private double menuItemPrice;

    internal MenuItem(string menuItemName, double menuItemPrice)
    {
        this.menuItemName = menuItemName;
        this.menuItemPrice = menuItemPrice;
    }

    internal void SetMenuItems(string menuItemName, double menuItemPrice)
    {
        this.menuItemName = menuItemName;
        this.menuItemPrice = menuItemPrice;
    }

    internal void DisplayMenuItem(int itemNumber)
    {
        Console.WriteLine(itemNumber + ". " + menuItemName +
            "\t----------------------------------------\t" + menuItemPrice);
    }

    internal double GetItemPrice()
    {
        return menuItemPrice;
    }
}

class CafeteriaMenuApp
{
    private static string adminName;
    private static string adminPassword;

    private MenuItem[] menuItems;

    static CafeteriaMenuApp()
    {
        adminName = "gaurav";
        adminPassword = "password123";
        Console.WriteLine("\n========== WELCOME TO THE CAFETERIA ==========\n");
    }

    static void Main(string[] args)
    {
        CafeteriaMenuApp app = new CafeteriaMenuApp();

        app.menuItems = new MenuItem[10]
        {
            new MenuItem("Tea", 10),
            new MenuItem("Coffee", 20),
            new MenuItem("Sandwich", 50),
            new MenuItem("Burger", 80),
            new MenuItem("Pizza", 120),
            new MenuItem("Fries", 40),
            new MenuItem("Momos", 60),
            new MenuItem("Cold Drink", 30),
            new MenuItem("Pasta", 90),
            new MenuItem("Ice Cream", 45)
        };

        app.StartApplication();
    }

    private void StartApplication()
    {
        Console.Write("Are you admin? (y/n): ");
        char userChoice = Console.ReadLine()[0];

        if (userChoice == 'y' && AuthenticateAdmin())
        {
            DisplayAdminMenu();
        }
        else
        {
            DisplayUserMenu();
        }
    }

    private bool AuthenticateAdmin()
    {
        Console.Write("Enter admin name: ");
        string name = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        if (!adminName.Equals(name) || !adminPassword.Equals(password))
        {
            Console.WriteLine("\nAuthentication Failed!\n");
            return false;
        }

        Console.WriteLine("\nAuthentication Successful!\n");
        return true;
    }

    private void DisplayUserMenu()
    {
        while (true)
        {
            Console.WriteLine("\n========== USER MENU ==========");
            Console.WriteLine("1. View Menu");
            Console.WriteLine("2. Place Order");
            Console.WriteLine("3. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DisplayMenu();
                    break;

                case 2:
                    PlaceOrder();
                    break;

                case 3:
                    return;
            }
        }
    }

    private void PlaceOrder()
    {
        Console.Write("Enter item number: ");
        int itemNumber = int.Parse(Console.ReadLine());

        if (itemNumber > 0 && itemNumber <= menuItems.Length)
        {
            Console.Write("Enter quantity: ");
            int qty = int.Parse(Console.ReadLine());

            ShowOrderSummary(itemNumber, qty);
        }
        else
        {
            Console.WriteLine("Invalid item number.");
        }
    }

    private void ShowOrderSummary(int itemNumber, int quantity)
    {
        Console.WriteLine("\n========== ORDER SUMMARY ==========\n");

        menuItems[itemNumber - 1].DisplayMenuItem(itemNumber);

        Console.WriteLine("Quantity\t----------------------------\t" + quantity);
        Console.WriteLine("Total Amount\t----------------------------\t" +
            (menuItems[itemNumber - 1].GetItemPrice() * quantity));
    }

    private void DisplayAdminMenu()
    {
        while (true)
        {
            Console.WriteLine("\n========== ADMIN MENU ==========");
            Console.WriteLine("1. Change Menu");
            Console.WriteLine("2. View Menu");
            Console.WriteLine("3. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ChangeMenu();
                    break;

                case 2:
                    DisplayMenu();
                    break;

                case 3:
                    return;
            }
        }
    }

    private void ChangeMenu()
    {
        for (int i = 0; i < menuItems.Length; i++)
        {
            Console.Write("Enter new name for item " + (i + 1) + ": ");
            string name = Console.ReadLine();

            Console.Write("Enter price: ");
            double price = double.Parse(Console.ReadLine());

            menuItems[i].SetMenuItems(name, price);
        }

        Console.WriteLine("\nMenu updated successfully!");
    }

    private void DisplayMenu()
    {
        Console.WriteLine("\n=========== MENU ===========\n");

        for (int i = 0; i < menuItems.Length; i++)
        {
            menuItems[i].DisplayMenuItem(i + 1);
        }
    }
}

