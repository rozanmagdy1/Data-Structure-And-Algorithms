namespace Data_Structure
{
	internal class CircularLinkedList
	{
		public int val;
		public CircularLinkedList? next;
		public CircularLinkedList(int val)
		{
			this.val = val;
			next = null;
		}

		public CircularLinkedList InsertAtBeginning(CircularLinkedList tail,
			int value) //O(1)
		{
			CircularLinkedList newNode = new CircularLinkedList(value);

			if(tail == null)
			{
				newNode.next = newNode;
				return newNode;
			}

			newNode.next = tail.next;
			tail.next = newNode;
			return newNode;
		}

		public CircularLinkedList InsertAtEnd(CircularLinkedList tail,
			int value) //O(1)
		{
			CircularLinkedList newNode = new CircularLinkedList(value);

			if (tail == null)
			{
				newNode.next = newNode;
				return newNode;
			}
			newNode.next = tail.next;
			tail.next = newNode;
			tail = newNode;

			return tail.next;
		}

		public CircularLinkedList InsertAt(CircularLinkedList tail,
			int value, int index) //O(n)
		{
			CircularLinkedList newNode = new CircularLinkedList(value);

			if (tail == null && index == 0)
			{
				newNode.next = newNode;
				return newNode;
			}

			if (tail != null)
			{
				if(index == 0)
				{
					newNode.next = tail.next;
					tail.next = newNode;
					return tail;
				} else
				{
					CircularLinkedList current = tail.next;
					int count = 0;

					while(current != null && count < index - 1)
					{
						current = current.next;
					}

					if(current != null)
					{
						newNode.next = current.next;
						current.next = newNode;
					}
				}

			}
			return tail.next;
		}

		public CircularLinkedList DeleteFromBeginning
			(CircularLinkedList tail)//O(1)
		{
			if(tail != null)
			{
				if (tail.next == tail) return null;
				tail.next = tail.next.next;
			}
			return tail.next;

		}

		public CircularLinkedList DeleteFromEnd(CircularLinkedList tail)
		{//O(n)
			if (tail != null)
			{
				if (tail.next == tail) return null;

				CircularLinkedList current = tail.next;

				while(current.next.next != null) { //second last
					current = current.next;
				}

				current.next = tail.next;
				tail = current;

			}
			return tail.next;

		}

		public CircularLinkedList DeleteAt(CircularLinkedList tail,
			int index)
		{//O(n)
			if (tail != null)
			{
				if(index == 0)
				{
					tail.next = tail.next.next;
					return tail.next;
				}

				CircularLinkedList current = tail.next;
				int count = 0;

				while (current != null && count < index - 1)
				{
					current = current.next;
				}

				if (current != null)
				{
					current.next = current.next.next;
				}

			} 
			return tail.next;

		}
	}
}
