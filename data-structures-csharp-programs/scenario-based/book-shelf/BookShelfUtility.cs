internal class BookShelfUtility: IBookShelf
{
    private NestedDoublyLinkedList genreList;

    public BookShelfUtility()
    {
        genreList = new NestedDoublyLinkedList();
    }

    public void ListAllGenres()
    {
        Console.WriteLine("\n==== GENRE LIST ====\n");
        if (genreList.IsEmpty())
        {
            Console.WriteLine("\nGenre list is empty...\n");
        }
        genreList.PrintList();
        Console.WriteLine("\n");
    }

    public void AddAGenre()
    {
        Console.WriteLine("\n==== GENRE ADDITION WINDOW ====\n");
        Console.Write("Enter genre name: ");
        string genreName = Console.ReadLine();
        Genre genre = new Genre(genreName);

        genreList.InsertAtEnd(genre);
        Console.WriteLine("\nGenre List updated...\n");
        ListAllGenres();
    }

    public void AddABook()
    {
        Console.WriteLine("\n==== BOOK ADDITION WINDOW ====\n");
        Console.Write("Enter Genre name: ");
        string genreName = Console.ReadLine();
        Console.Write("Enter Book name: ");
        string bookName = Console.ReadLine();
        Console.Write("Enter Author name: ");
        string authorName = Console.ReadLine();

        Genre genre = genreList.FindGenre(genreName);

        if(genre == null)
        {
            genre = new Genre(genreName);
            genreList.InsertAtEnd(genre);
        }

        Book book = new Book(bookName, authorName);

        genre.GetGenreBooksList().InsertAtEnd(book);
        Console.WriteLine("\nBook added successfully...\n");
    }

    public void ListAllBooks()
    {
        genreList.PrintBooksGenreWise();
    }
}