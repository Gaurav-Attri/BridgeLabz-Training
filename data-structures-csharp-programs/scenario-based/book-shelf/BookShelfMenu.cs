using System.ComponentModel;

internal class BookShelfMenu()
{
    private IBookShelf bookShelfUtility;

    public void ShowBookShelfMenu()
    {
        bookShelfUtility = new BookShelfUtility();
        int choice;

        do
        {
            Console.WriteLine("\n==== BOOK SHELF MANAGER ====\n");
            Console.WriteLine("1. List all genre.");
            Console.WriteLine("2. Add a genre.");
            Console.WriteLine("3. Add a book");
            Console.WriteLine("4. List all books");
            Console.WriteLine("0. Exit");
            Console.Write("Enter you choice number: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    bookShelfUtility.ListAllGenres();
                    break;
                case 2:
                    bookShelfUtility.AddAGenre();
                    break;
                case 3:
                    bookShelfUtility.AddABook();
                    break;
                case 4:
                    bookShelfUtility.ListAllBooks();
                    break;
            }

        } while (choice != 0);
    }
}