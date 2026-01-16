internal class NestedDoublyLinkedList
{
    private ListNode head;
    private ListNode tail;
    private int size;

    private class ListNode
    {
        public Genre GenreData;
        public ListNode Next;
        public ListNode Prev;

        public ListNode(Genre genreData)
        {
            GenreData = genreData;
        }
    }

    public void InsertAtEnd(Genre genre)
    {
        ListNode node = new ListNode(genre);

        if (head == null)
        {
            head = tail = node;
            size++;
            return;
        }
        node.Prev = tail;
        tail.Next = node;
        tail = node;
        size++;
    }

    public Genre RemoveFromEnd()
    {
        if (size == 0)
        {
            return null;
        }
        Genre removedGenre = null;

        // When there's only one node
        if (size == 1)
        {
            removedGenre = head.GenreData;
            head = tail = null;
            size--;
            return removedGenre;
        }

        ListNode oldTail = tail;
        removedGenre = oldTail.GenreData;
        tail = tail.Prev;
        tail.Next = null;
        oldTail.Prev = null;

        size--;
        return removedGenre;
    }

    public Genre RemoveFromStart()
    {
        if (size == 0)
        {
            return null;
        }

        Genre removedGenre = null;

        if (size == 1)
        {
            removedGenre = head.GenreData;
            head = tail = null;
            size--;
            return removedGenre;
        }

        ListNode oldHead = head;
        removedGenre = oldHead.GenreData;
        head = head.Next;
        head.Prev = null;
        oldHead.Next = null;
        size--;
        return removedGenre;
    }

    public Genre RemoveByBookName(string genreName)
    {
        if (size == 0)
        {
            return null;
        }

        ListNode temp = head;

        while (temp != null && !temp.GenreData.GetGenreName().Equals(genreName))
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            return null;
        }

        if (temp == head)
        {
            return RemoveFromStart();
        }

        if (temp == tail)
        {
            return RemoveFromEnd();
        }

        Genre removedGenre = temp.GenreData;
        temp.Prev.Next = temp.Next;
        temp.Next.Prev = temp.Prev;
        temp.Next = null;
        temp.Prev = null;
        size--;
        return removedGenre;
    }

    public void PrintList()
    {

        ListNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.GenreData.GetGenreName());
            temp = temp.Next;
        }
    }

    public bool IsBookPresent(string genreName)
    {
        ListNode temp = head;
        while (temp != null)
        {
            if (temp.GenreData.GetGenreName().Equals(genreName))
            {
                return true;
            }

            temp = temp.Next;
        }
        return false;
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    public int Size()
    {
        return size;
    }

    public Genre FindGenre(string genreName)
    {
        ListNode temp = head;
        while (temp != null)
        {
            if (temp.GenreData.GetGenreName().Equals(genreName))
            {
                return temp.GenreData;
            }
            temp = temp.Next;
        }

        return null;
    }
    
    public void PrintBooksGenreWise()
    {
        if(head != null)
        {
            ListNode temp = head;
            Console.WriteLine($"\nGenre Name:{temp.GenreData.GetGenreName()}");
            Console.WriteLine("=========");

            while (temp != null)
            {
                DoublyLinkedList bookList = temp.GenreData.GetGenreBooksList();
                bookList.PrintList();
                temp = temp.Next;
            }
            Console.WriteLine("\n");
        }
    }
}