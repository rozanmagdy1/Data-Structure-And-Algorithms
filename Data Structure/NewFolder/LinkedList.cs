namespace Data_Structure.NewFolder
{
    internal class LinkedList
    {
        public class Node
        {
            public Node? next;
            public int data;

            public Node(int value)
            {
                data = value;
                next = null;
            }
        }
        public Node head;

        public void LinkedListTraverse()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

        public void InsertAtTail(int data)
        {
            Node newNode = new Node(data);

            Node current = head;
            if (current != null)
            {
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
            else //empty list
            {
                head = newNode;
            }
        }

        public void InsertAtHead(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public void InsertAtPosition(int data, int position)
        {
            Node newNode = new Node(data);

            int count = 0;
            Node temp = head;
            while (count < position - 1 && temp != null)
            {
                temp = temp.next;
                count++;
            }

            if (temp != null)
            {
                newNode.next = temp.next;
                temp.next = newNode;
            }
        }




        public void DeleteAtHead()
        {
            if (head != null)
            {
                head.next = head;
            }
        }

        public void DeleteAtTail()
        {
            if (head.next == null)//only one node
            {
                head = null;
            }

            Node current = head;
            while (current.next.next != null) //the second last
            {
                current = current.next;
            }
            current.next = null;

        }

        public Node DeleteAtPosition(int pos)
        {
            if (head == null) return null;

            if (pos == 0)
            {
                head = head.next;
                return head;
            }

            int count = 0;
            Node temp = head;
            while (count < pos - 1 && temp != null)
            {
                temp = temp.next;
                count++;
            }
            if (temp != null && temp.next != null)
                temp.next = temp.next.next;

            return head;
        }




        public void ReverseLinkedList()
        {
            Stack<Node> stack = new Stack<Node>();
            if (head != null)
            {
                Node temp = head;
                while (temp != null)
                {
                    stack.Push(temp);
                    temp = temp.next;
                }

                Node newHead = stack.Pop();
                Node currentNew = newHead;

                while (stack.Count > 0)
                {
                    currentNew.next = stack.Pop();
                    currentNew = currentNew.next;
                }

                currentNew.next = null;
            }

        }

        public void DeleteNodes(int x)
        {
            if (head != null)
            {
                Node current = head;

                if (head.data >= x)
                {
                    head = head.next;
                }

                while (current.next != null)
                {
                    if (current.next.data >= x)
                    {
                        current.next = current.next.next;
                    }
                    else
                    {
                        current = current.next;
                    }
                }

            }





        }

        public bool CompareLists(Node head1, Node head2)
        {
            Node currentList1 = head1;
            Node currentList2 = head2;
            while (currentList1 != null && currentList2 != null)
            {
                if (currentList1.data != currentList2.data)
                {
                    return false;
                }
                if (currentList1.next == null && currentList2.next != null ||
                    currentList2.next == null && currentList1.next != null)
                {
                    return false;
                }
                currentList1 = currentList1.next;
                currentList2 = currentList2.next;
            }
            return true;
        }

        public Node MergeLists(Node head1, Node head2)
        {
            Node dummy = new Node(0);

            Node temp = dummy;

            while (true)
            {
                if (head1 == null)
                {
                    temp.next = head2.next;
                    break;
                }
                else if (head2 == null)
                {
                    temp.next = head1.next;
                    break;
                }
                else if (head1.data < head2.data)
                {
                    temp.next = head1.next;
                    head1 = head1.next;
                }
                else
                {
                    temp.next = head2.next;
                    head2 = head2.next;
                }
                temp = temp.next;
            }
            return dummy.next;

        }

    }
}
