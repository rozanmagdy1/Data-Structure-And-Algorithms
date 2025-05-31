using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Data_Structure.NewFolder
{
    internal class DoublyLinkedList
    {
        public class Node
        {
            public Node? next;
            public Node? prev;
            public int data;

            public Node(int value)
            {
                data = value;
                next = prev = null;
            }
        }
        public Node head;
        public Node tail;

        public Node ReverseLinkedListFromTail() //from tail
        {
            Node newHead = tail;
            Node current = tail;
            while (current != null)
            {
                newHead.next = current.prev;
                current = current.prev;
            }
            return newHead;
        }

        //public Node ReverseLinkedListFromHead() //from tail
        //{

        //}

        public Node sortedInsert(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            { //empty
                return newNode;
            }

            bool inserted = false;
            Node current = head;
            while (current != null)
            {
                if (current.data > data) //insert it before current
                {
                    newNode.prev = current.prev;
                    newNode.next = current;
                    current.prev.next = newNode;
                    current.prev = newNode;
                    inserted = true;
                }
                current = current.next;
            }
            if (!inserted) //insert it at the end
            {
                newNode.prev = current;
                current.next = newNode;
            }

            return head;
        }
    }
}
