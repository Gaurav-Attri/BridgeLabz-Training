class StudentLinkedList
{
    private ListNode head;
    private ListNode tail;
    private int size;

    private class ListNode
    {
        public Student StudentData;
        public ListNode Next;
        public ListNode Prev;

        public ListNode(Student studentData)
        {
            StudentData = studentData;
        }
    }

    public void InsertAtEnd(Student student)
    {
        ListNode node = new ListNode(student);

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

    public Student RemoveFromEnd()
    {
        if (size == 0)
        {
            return null;
        }
        Student removedStudent = null;

        // When there's only one node
        if (size == 1)
        {
            removedStudent = head.StudentData;
            head = tail = null;
            size--;
            return removedStudent;
        }

        ListNode oldTail = tail;
        removedStudent = oldTail.StudentData;
        tail = tail.Prev;
        tail.Next = null;
        oldTail.Prev = null;

        size--;
        return removedStudent;
    }

    public Student RemoveFromStart()
    {
        if (size == 0)
        {
            return null;
        }

        Student removedStudent = null;

        if (size == 1)
        {
            removedStudent = head.StudentData;
            head = tail = null;
            size--;
            return removedStudent;
        }

        ListNode oldHead = head;
        removedStudent = oldHead.StudentData;
        head = head.Next;
        head.Prev = null;
        oldHead.Next = null;
        size--;
        return removedStudent;
    }

    public Student RemoveByStudentName(string studentName)
    {
        if (size == 0)
        {
            return null;
        }

        ListNode temp = head;

        while (temp != null && !temp.StudentData.GetStudentName().Equals(studentName))
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

        Student removedStudent = temp.StudentData;
        temp.Prev.Next = temp.Next;
        temp.Next.Prev = temp.Prev;
        temp.Next = null;
        temp.Prev = null;
        size--;
        return removedStudent;
    }

    public Student RemoveByStudentId(int studentId)
    {
        if (size == 0)
        {
            return null;
        }

        ListNode temp = head;

        while (temp != null && !(temp.StudentData.GetStudentId() == studentId))
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

        Student removedStudent = temp.StudentData;
        temp.Prev.Next = temp.Next;
        temp.Next.Prev = temp.Prev;
        temp.Next = null;
        temp.Prev = null;
        size--;
        return removedStudent;
    }

    public void PrintList()
    {

        ListNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.StudentData);
            temp = temp.Next;
        }
    }

    public bool IsStudentPresent(int studentId)
    {
        ListNode temp = head;
        while (temp != null)
        {
            if (temp.StudentData.GetStudentId() == studentId)
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

    public Student FindStudentById(int studentId)
    {
        ListNode temp = head;
        while (temp != null)
        {
            if (temp.StudentData.GetStudentId() == studentId)
            {
                return temp.StudentData;
            }
            temp = temp.Next;
        }

        return null;
    }

    public void InitializeQuestionsResponsesArray(int size)
    {
        ListNode temp = head;
        while(temp != null)
        {
            temp.StudentData.SetQuestionsResponsesArraySize(size);
            temp = temp.Next;
        }
    }

    public void PrintScores()
    {
        ListNode temp = head;
        while (temp != null)
        {
            Console.WriteLine($"\n{temp.StudentData.GetStudentName()}\t\t{temp.StudentData.GetScore()}");
            temp = temp.Next;
        }
    }
}