internal class Book
{
    private string bookName;
    private string bookAuthor;

    public Book(string bookName, string bookAuthor)
    {
        this.bookName = bookName;
        this.bookAuthor = bookAuthor;
    }

    public string GetBookName()
    {
        return bookName;
    }

    public void SetBookName(string bookName)
    {
        this.bookName = bookName;
    }

    public string GetBookAuthor()
    {
        return bookAuthor;
    }

    public void SetBookAuthor(string bookAuthor)
    {
        this.bookAuthor= bookAuthor;
    }

    public override string ToString()
    {
        return $"\nBook Name: {bookName}\nBook Author: {bookAuthor}";
    }
}