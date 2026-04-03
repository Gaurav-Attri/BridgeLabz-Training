class AdharNumberSystemMenu
{
    private IAdharNumberSystem adharNumberUtility;

    public void ShowAdharNumberSystemMenu()
    {
        adharNumberUtility = new AdharNumberUtility();
        int choice;
        do
        {
            Console.WriteLine("\n==== ADHAR NUMBER SYSTEM ====\n");
            Console.WriteLine("1. Add Adhar Number.");
            Console.WriteLine("2. Display all Adhar Numbers.");
            Console.WriteLine("3. Search Adhar Number.");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice number: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            switch (choice)
            {
                case 1:
                    adharNumberUtility.AddAdharNumber();
                    break;
                case 2:
                    adharNumberUtility.DisplayAllAdharNumbers();
                    break;
                case 3:
                    adharNumberUtility.SearchAdharNumber();
                    break;
            }

        } while (choice != 0);
    }
}