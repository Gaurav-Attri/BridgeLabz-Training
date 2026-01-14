internal class AddressBook
{
    private readonly Contact[] Contacts;
    private readonly int MaxSize;
    private int CurrentIndex;

    public AddressBook(int maxSize)
    {
        MaxSize = maxSize;
        Contacts = new Contact[MaxSize];
        CurrentIndex = 0;
    }

    // Creating getter methods for all the fields and setter method for CurrentIndex only because Contacts array and MaxSize are readonly.
    public int GetMaxSize()
    {
        return MaxSize;
    }

    public Contact[] GetContacts()
    {
        return Contacts;
    }

    public int GetCurrentIndex()
    {
        return CurrentIndex;
    }

    public void SetCurrentIndex(int index)
    {
        CurrentIndex = index;
    }

    // Overriding ToString to allow printing an address book.
    public override string ToString()
    {
        return $"Max Size: {MaxSize} | Current Index: {CurrentIndex}";
    }

}