internal class Genre
{
    private string genreName;
    private DoublyLinkedList genreBooksList;

    public Genre(string genreName)
    {
        this.genreName = genreName;
        genreBooksList = new DoublyLinkedList();
    }

    public string GetGenreName()
    {
        return genreName; 
    }

    public void SetGenreName(string genreName)
    {
        this.genreName = genreName;
    }

    public DoublyLinkedList GetGenreBooksList()
    {
        return genreBooksList;
    }
}