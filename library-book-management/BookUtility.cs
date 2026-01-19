using System.Security.AccessControl;

class BookUtility : IBook
{
    private static Book[] _totalBooks;
    private static int _totalBooksPointer;
    // Can store upto 20 books
    private static int _bookCapacity = 2;

    static BookUtility()
    {
        _totalBooks = new Book[_bookCapacity];
        _totalBooksPointer = 0;
    }

    public void AddBook()
    {
        Console.WriteLine("\n==== BOOK ADDING WINDOW ====\n");

        if(_totalBooksPointer >= _bookCapacity)
        {
            Console.WriteLine("\nBook Array is full...\n");
            return;
        }

        Console.Write("Enter book name: ");
        string bookName = Console.ReadLine();
        Console.Write("Enter book author: ");
        string bookAuthor = Console.ReadLine();

        Book book = new Book(bookName, bookAuthor);

        _totalBooks[_totalBooksPointer++] = book;
        SortBooks();
        Console.WriteLine("\nBook added succesfully\n");
    }

    public void DisplayAllBooks()
    {
        Console.WriteLine("\n==== ALL BOOKS ====\n");
        if(_totalBooksPointer == 0)
        {
            Console.WriteLine("\nCurrently, there are zero books in the library.\n");
            return;
        }

        for(int i = 0; i < _totalBooksPointer; i++)
        {
            Console.WriteLine(_totalBooks[i]);
        }
        Console.WriteLine("\n");
    }

    public void ListIssuedBooks()
    {
        Console.WriteLine("\n==== ISSUED BOOKS ====\n");
        if (_totalBooksPointer == 0)
        {
            Console.WriteLine("\nCurrently, there are zero books issued.\n");
            return;
        }

        for (int i = 0; i < _totalBooksPointer; i++)
        {
            if (!_totalBooks[i].GetAvialability()) Console.WriteLine(_totalBooks[i]);
        }
        Console.WriteLine("\n");
    }

    public void IssueBook()
    {
        Console.WriteLine("\n==== BOOK ISSUE WINDOW ====\n");
        Console.Write("Enter book name: ");
        string bookName = Console.ReadLine();
        Console.WriteLine("\n");
        Book book = IsBookAvailable(bookName);
        if (book == null)
        {
            Console.WriteLine("\nBook not found\n");
            return;
        }
        if (!book.GetAvialability())
        {
            Console.WriteLine("\nBook not available right now.\n");
            return;
        }
        book.SetAvailability(false);
        Console.WriteLine("\nBook issued successfully\n");
    }

    public void CheckBookAvailability()
    {
        Console.WriteLine("\n==== BOOK AVAILABLITY CHECK WINDOW ====\n");
        Console.Write("Enter book name: ");
        string bookName = Console.ReadLine();
        Book book = IsBookAvailable(bookName);
        if(book == null)
        {
            Console.WriteLine("\nBook not found\n");
            return;
        }
        if (!book.GetAvialability())
        {
            Console.WriteLine("\nBook not available\n");
            return;
        }
        Console.WriteLine("\nBook available\n");
        
    }

    private Book IsBookAvailable(string bookName)
    {
        int low = 0;
        int high = _totalBooksPointer - 1;

        while(low <= high)
        {
            int mid = (low + high) / 2;
            Book currentBook = _totalBooks[mid];
            if (currentBook.GetBookName().Equals(bookName)) return currentBook;
            else if (String.Compare(currentBook.GetBookName(), bookName) > 0) high = mid - 1;
            else low = mid + 1;
        }

        return null;
    }

    private void SortBooks()
    {
        for(int i = 1; i < _totalBooksPointer; i++)
        {
            Book key = _totalBooks[i];
            int j = i-1;
            while (j >= 0 && String.Compare(_totalBooks[j].GetBookName(), key.GetBookName()) > 0)
            {
                _totalBooks[j + 1] = _totalBooks[j];
                j--;
            }
            _totalBooks[j + 1] = key;
        }
    }
}