internal class NavigationStack
{
    private int size;
    private ListNode head;

    private class ListNode
    {
        public int QuestionNumber;
        public ListNode Next;

        public ListNode(int questionNumber)
        {
            QuestionNumber = questionNumber;
        }
    }

    // Method to push a Page on PageStack
    public void Push(int questionNumber)
    {
        ListNode node = new ListNode(questionNumber);

        node.Next = head;
        head = node;
        size++;
    }

    // Method to pop a Page from PageStack
    public int Pop()
    {
        if (head == null)
        {
            return -1;
        }

        int poppedQuestionNumber = head.QuestionNumber;
        head = head.Next;
        size--;
        return poppedQuestionNumber;
    }

    // Method to peek a Page from PageStack
    public int Peek()
    {
        if (head == null)
        {
            return -1;
        }

        return head.QuestionNumber;
    }

    // Method to check if the stack is empty
    public bool IsEmpty()
    {
        return size == 0;
    }

    // Method to get the stack size
    public int StackSize()
    {
        return size;
    }

    // Method to clear the entire stack
    public void Clear()
    {
        head = null;
        size = 0;
    }
}