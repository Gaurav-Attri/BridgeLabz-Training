internal class BookMenu
{
    private IBook bookUtility;

    public void ShowBookMenu()
    {
        bookUtility = new BookUtility();
        Console.WriteLine("\n==== BOOK MANAGEMENT SYSTEM ====\n");
        int choice;
        do
        {
            Console.WriteLine("1. Display all books.");
            Console.WriteLine("2. Add a book");
            Console.WriteLine("3. Issue book");
            Console.WriteLine("4. Check Book availability");
            Console.WriteLine("5. Display all issued books.");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice number: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            switch (choice)
            {
                case 1:
                    bookUtility.DisplayAllBooks();
                    break;
                case 2:
                    bookUtility.AddBook();
                    break;
                case 3:
                    bookUtility.IssueBook();
                    break;
                case 4:
                    bookUtility.CheckBookAvailability();
                    break;
                case 5:
                    bookUtility.ListIssuedBooks();
                    break;
            }
        } while (choice != 0);
    }
}