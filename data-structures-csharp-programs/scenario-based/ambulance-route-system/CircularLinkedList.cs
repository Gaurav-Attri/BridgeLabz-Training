class CircularLinkedList
{
    public class Node
    {
        public Building data;
        public Node next;

        public Node(Building value)
        {
            data = value;
        }
    }

    private Node head;

    public void Add(Building building)
    {
        Node newNode = new Node(building);

        if (head == null)
        {
            head = newNode;
            head.next = head;
            return;
        }

        Node temp = head;
        while (temp.next != head)
        {
            temp = temp.next;
        }

        temp.next = newNode;
        newNode.next = head;
    }

    public void Remove(string buildingName)
    {
        if (head == null)
            return;

        Node current = head;
        Node prev = null;

        do
        {
            if (current.data.GetName() == buildingName)
            {
                if (prev != null)
                {
                    prev.next = current.next;
                }
                else
                {
                    Node last = head;
                    while (last.next != head)
                    {
                        last = last.next;
                    }
                    head = head.next;
                    last.next = head;
                }
                return;
            }

            prev = current;
            current = current.next;

        } while (current != head);
    }

    public Node GetHead()
    {
        return head;
    }
}
