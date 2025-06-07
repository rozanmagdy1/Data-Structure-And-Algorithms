namespace Data_Structure.Problems
{
	internal class LinkedListProblems
	{
		//leet code problem 21
		public ListNode MergeTwoSortedLists(ListNode list1, ListNode list2)
		{
			if (list1 == null && list2 == null) return null;

			ListNode mergedList = new ListNode(0);
			while (list1 != null && list2 != null)
			{
				if (list1.val <= list2.val)
				{
					ListNode newNode = new ListNode(list1.val);
					mergedList.next = newNode;
					list1 = list1.next;
				}
				else
				{
					ListNode newNode = new ListNode(list2.val);
					mergedList.next = newNode;
					list2 = list2.next;
				}
			}

			while (list1 != null)
			{
				ListNode newNode = new ListNode(list2.val);
				mergedList.next = newNode;
				list1 = list1.next;
			}

			while (list2 != null)
			{
				ListNode newNode = new ListNode(list2.val);
				mergedList.next = newNode;
				list2 = list2.next;
			}

			return mergedList.next;
		}
		
		/********************************************/

		//leet code problem 2
		public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			ListNode resultList = new ListNode(0);
			ListNode current = resultList;
			int carry = 0;

			while (l1 != null || l2 != null)
			{
				int sum = carry;

				if (l1 != null)
				{
					sum += l1.val;
					l1 = l1.next;
				}
				if (l2 != null)
				{
					sum += l2.val;
					l2 = l2.next;
				}

				current.next = new ListNode(sum % 10);
				current = current.next;
				carry = sum / 10;

			}

			if (carry != 0)
			{
				current.next = new ListNode(carry);
			}

			return resultList.next;
		}

		/********************************************/

		//leet code problem 206
		public static ListNode ReverseList(ListNode head)
		{
			//Complexity O(2n)
			//Stack<int> values = new Stack<int>();
			//ListNode reveredList = new ListNode(0);

			//ListNode current = head;
			//while (current != null)
			//{
			//	values.Push(current.val);
			//	current = current.next;
			//}

			//ListNode reveredListTemp = reveredList;
			//while (values.Count > 0)
			//{
			//	ListNode newNode = new ListNode(values.Pop());
			//	reveredListTemp.next = newNode;
			//	reveredListTemp = reveredListTemp.next;
			//}

			//return reveredList.next;

			//Other solution
			ListNode prev = null;
			ListNode current = head;
			ListNode front = current.next;

			while (current != null)
			{
				front = current.next;
				current.next = prev;
				prev = current;
				current = front;
			}
			return front;

		}

		/********************************************/

		//leet code problem 203
		//Noon interview question
		//Remove elements from linked list that value > n
		public static ListNode RemoveNodes(ListNode head, int val)
		{
			ListNode result = new ListNode(0);
			ListNode temp = result;

			ListNode current = head;
			while (current != null)
			{
				if (current.val != val)
				{
					temp.next = new ListNode(current.val);
					temp = temp.next;
				}
				current = current.next;

			}
			return result.next;

		}

		/********************************************/

		//leet code problem 876
		public ListNode MiddleNode(ListNode head)
		{
			//O(n) complexity
			//Dictionary<int, ListNode> dict = new Dictionary<int, ListNode>();
			//int counter = 0;

			//ListNode current = head;
			//while (current != null)
			//{
			//	counter++;
			//	dict[counter] = current;
			//	current = current.next;
			//}

			//int midPoint = (counter / 2) + 1;
			//return dict[midPoint];

			//O(n/2) complexity using Two pointers (Tortoise and hare)
			ListNode fast = head;
			ListNode slow = head;

			while(fast != null && fast.next != null)
			{
				slow = slow.next;
				fast = fast.next.next;
			}
			return slow;
		}

		/********************************************/
		//leet code problem 19
		//public ListNode RemoveNthFromEnd(ListNode head)
		//{

		//}

		/********************************************/
		//leet code problem 234
		public static bool IsPalindrome(ListNode head)
		{
			//let's reverse the list then compare
			ListNode reversed = ReverseList(head);

			bool plaindrome = true;
			//compare head and front
			while (head != null && reversed != null)
			{
				if (head.val != reversed.val)
				{
					plaindrome = false;
				}
				head = head.next;
				reversed = reversed.next;
			}
			return plaindrome;
		}

		/********************************************/
		//leet code problem 141
		//public ListNode HasCycle(ListNode head)
		//{

		//}

		/********************************************/
		//leet code problem 106
		//public ListNode GetIntersectionNode(ListNode head)
		//{

		//}

		/********************************************/
		//leet code problem 92
		//public ListNode ReverseBetween(ListNode head, int left, int right)
		//{

		//}
	}
}
