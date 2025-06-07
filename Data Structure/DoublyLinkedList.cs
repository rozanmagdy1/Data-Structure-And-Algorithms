namespace Data_Structure
{
	internal class DoublyLinkedList
	{
		public int val;
		public DoublyLinkedList? next;
		public DoublyLinkedList? prev;
		public DoublyLinkedList(int val)
		{
			this.val = val;
			next = prev = null;
		}

		public DoublyLinkedList InsertAtBeginning(DoublyLinkedList head,
			int value) //O(1)
		{
			DoublyLinkedList newNode = new DoublyLinkedList(value);
			newNode.next = head;
			//newNode.prev == null by default

			if (head != null)
			{
				head.prev = newNode;
			}

			return newNode;
		}

		public DoublyLinkedList InsertAtEnd(DoublyLinkedList head,
			int value) //O(n)
		{
			DoublyLinkedList newNode = new DoublyLinkedList(value);

			if (head == null) //first node
			{
				return newNode;
			}
			else
			{
				DoublyLinkedList current = head;
				while (current.next != null) //to get last node
				{
					current = current.next;
				}

				newNode.prev = current;
				//newNode.next = null by default

				current.next = newNode;
			}
			return head;

		}

		public DoublyLinkedList InsertAt(int index, int value, DoublyLinkedList head)//O(n)
		{
			DoublyLinkedList newNode = new DoublyLinkedList(value);

			if (head == null && index == 1)
			{
				return newNode;
			}

			if (head != null && index == 1)
			{
				newNode.next = head;
				head.prev = newNode;
				return newNode;
			}

			int count = 1;
			DoublyLinkedList current = head;
			while (count < index - 1 && current != null)
			{
				current = current.next;
				count++;
			}

			if (current != null)
			{
				newNode.prev = current;
				newNode.next = current.next;

				current.next = newNode;

				if (newNode.next != null)
					newNode.next.prev = newNode;

			}
			return head;

		}

		public DoublyLinkedList DeleteAtBeginning(DoublyLinkedList head)//O(1)
		{
			if (head == null) return null;
			if (head.next == null) return null;
			head = head.next;
			head.prev = null;
			return head;
		}


		public DoublyLinkedList DeleteAtEnd(DoublyLinkedList head)//O(n)
		{
			if (head == null) return null;
			if (head.next == null) return null;

			DoublyLinkedList current = head;
			while(current.next.next != null) //second last
			{
				current = current.next;
			}
			current.next = null;
			return head;
		}

		public DoublyLinkedList RemoveAt(int index, DoublyLinkedList head)//O(n)
		{
			if(head != null)
			{
				if(index == 0)
				{
					//remove head
					head = head.next;
					if (head != null)
						head.prev = null;
				}
				else
				{
					DoublyLinkedList current = head;
					int count = 0;

					while (current != null && count < index)
					{
						current = current.next;
						count++;
					}

					if(current != null) //the current is node to remove
					{
						if(current.prev != null)
						{
							current.prev.next = current.next;
						}

						if (current.next != null)
						{
							current.next.prev = current.prev;
						}
					}
				}
			}
			return head;

		}
		public void LinkedListTraverse(DoublyLinkedList head)//O(n)
		{
			DoublyLinkedList temp = head;
			while (temp != null)
			{
				Console.WriteLine(temp.val);
				temp = temp.next;
			}
		}


	}
}
