class Book
{
    private static int _idCounter = 0;
    private int _bookId;
    private string _bookName;
    private string _bookAuthor;
    private bool _isAvailable;

    public Book(string bookName, string bookAuthor)
    {
        _bookId = ++_idCounter;
        _bookName = bookName;
        _bookAuthor = bookAuthor;
        _isAvailable = true;
    }

    public int GetBookId()
    {
        return _bookId;
    }

    public string GetBookName()
    {
        return _bookName;
    }

    public string GetBookAuthor()
    {
        return _bookAuthor;
    }

    public bool GetAvialability()
    {
        return _isAvailable;
    }

    public void SetAvailability(bool availability)
    {
        _isAvailable = availability;
    }

    public override string ToString()
    {
        return $"\nBook Id: {_bookId}\t|\tBook Name: {_bookName}\t|\tBook Author: {_bookAuthor}\t|\tAvailability: {_isAvailable}\n";
    }
}