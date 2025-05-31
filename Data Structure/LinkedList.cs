namespace Data_Structure
{
	internal class ListNode
	{
		public int val;
		public ListNode? next;
		public ListNode(int val)
		{
			this.val = val;
			next = null;
		}

		//Insert
		public ListNode InsertAtBeginning(ListNode head, int value) //O(1)
		{
			ListNode newNode = new ListNode(value);
			newNode.next = head;
			return newNode;
		}

		public ListNode InsertAtEnd(ListNode head, int value) //O(n)
		{
			ListNode newNode = new ListNode(value);
			if (head == null) //first node
			{
				return newNode;
			}
			else
			{
				ListNode current = head;
				while (current.next != null) //to get the last element
				{
					current = current.next;
				}
				current.next = newNode;
			}

			return head;
		}

		public ListNode InsertAt(int index, int value, ListNode head)//O(n)
		{
			ListNode newNode = new ListNode(value);
			if (head == null && index == 0) return newNode;

			if (head != null && index == 0)
			{
				newNode.next = head;
				return newNode;
			}

			int count = 0;
			ListNode current = head;
			while (count < index - 1 && current != null)
			{
				current = current.next;
				count++;
			}

			if (current != null)
			{
				newNode.next = current.next;
				current.next = newNode;
			}
			return head;

		}

		//delete
		public ListNode DeleteAtBeginning(ListNode head)//O(1)
		{
			if (head != null)
			{
				head = head.next;
			}
			return head;
		}

		public ListNode DeleteAtEnd(ListNode head)//O(n)
		{
			if (head == null || head.next == null)
			{
				head = null;
			}

			ListNode current = head;
			while (current.next.next != null) //to get second the last one
			{
				current = current.next;
			}
			current.next = null;
			return head;
		}


		public ListNode RemoveAt(int index, ListNode head)//O(n)
		{
			if (head != null)
			{
				if(index == 0)
				{
					head = head.next;
				}
				else
				{
					int count = 0;
					ListNode current = head;
					while (count < index - 1 && current != null)
					{
						current = current.next;
						count++;
					}

					if (current != null && current.next != null)
					{
						current.next = current.next.next;
					}
				}
			}
			return head;
		}

		public void LinkedListTraverse(ListNode head)//O(n)
		{
			ListNode temp = head;
			while (temp != null)
			{
				Console.WriteLine(temp.val);
				temp = temp.next;
			}
		}

	}
}
