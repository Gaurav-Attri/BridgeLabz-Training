internal class DoublyLinkedList
{
    private ListNode head;
    private ListNode tail;
    private int size;

    private class ListNode
    {
        public Book BookData;
        public ListNode Next;
        public ListNode Prev;

        public ListNode(Book book)
        {
            BookData = book;
        }
    }

    public void InsertAtEnd(Book book)
    {
        ListNode node = new ListNode(book);

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

    public Book RemoveFromEnd()
    {
        if (size == 0)
        {
            return null;
        }
        Book removedBook = null;

        // When there's only one node
        if (size == 1)
        {
            removedBook = head.BookData;
            head = tail = null;
            size--;
            return removedBook;
        }

        ListNode oldTail = tail;
        removedBook = oldTail.BookData;
        tail = tail.Prev;
        tail.Next = null;
        oldTail.Prev = null;

        size--;
        return removedBook;
    }

    public Book RemoveFromStart()
    {
        if (size == 0)
        {
            return null;
        }

        Book removedBook = null;

        if (size == 1)
        {
            removedBook = head.BookData;
            head = tail = null;
            size--;
            return removedBook;
        }

        ListNode oldHead = head;
        removedBook = oldHead.BookData;
        head = head.Next;
        head.Prev = null;
        oldHead.Next = null;
        size--;
        return removedBook;
    }

    public Book RemoveByBookName(string bookName)
    {
        if (size == 0)
        {
            return null;
        }

        ListNode temp = head;

        while (temp != null && !temp.BookData.GetBookName().Equals(bookName))
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

        Book removedBook = temp.BookData;
        temp.Prev.Next = temp.Next;
        temp.Next.Prev = temp.Prev;
        temp.Next = null;
        temp.Prev = null;
        size--;
        return removedBook;
    }

    public void PrintList()
    {

        ListNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.BookData);
            temp = temp.Next;
        }
    }

    public bool IsBookPresent(string bookName)
    {
        ListNode temp = head;
        while (temp != null)
        {
            if (temp.BookData.GetBookName().Equals(bookName))
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

    public Book FindBook(string bookName)
    {
        ListNode temp = head;
        while (temp != null)
        {
            if (temp.BookData.GetBookName().Equals(bookName))
            {
                return temp.BookData;
            }
            temp = temp.Next;
        }

        return null;
    }
}