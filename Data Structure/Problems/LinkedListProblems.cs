namespace Data_Structure.Problems
{
	internal class LinkedListProblems
	{
		//leet code problem 876
		public static ListNode MiddleNode(ListNode head)
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

			//***************************************//

			//another O(n + n/2) solution
			//ListNode current = head;
			//int length = 0;

			//while (current != null)
			//{
			//	current = current.next;
			//	length++;
			//}

			//int midCount = 0;
			//if (length % 2 == 0)
			//{
			//	 midCount = (length - 1) / 2;
			//} else
			//{
			//	 midCount = ((length - 1) / 2) + 1;
			//}

			//current = head;
			//while ( midCount > 0 )
			//{
			//	current = current.next;
			//	midCount--;
			//}
			//return current;

			//***************************************//

			//O(n/2) complexity using Two pointers (Tortoise and hare)
			ListNode fast = head;
			ListNode slow = head;

			while (fast != null && fast.next != null)
			{
				slow = slow.next;
				fast = fast.next.next;
			}
			return slow;
		}

		/********************************************/

		//leet code problem 21
		public static ListNode MergeTwoSortedLists
			(ListNode list1, ListNode list2)
		{
			ListNode dummy = new ListNode(0);
			ListNode current = dummy;

			while (list1 != null && list2 != null)
			{
				if(list1.val <= list2.val)
				{
					current.next = new ListNode(list1.val);
					list1 = list1.next;
				} else
				{
					current.next = new ListNode(list2.val);
					list2 = list2.next;
				}
				current = current.next;
			}

			while (list1 != null)
			{
				current.next = new ListNode(list1.val);
				list1 = list1.next;
				current = current.next;
			}

			while (list2 != null)
			{
				current.next = new ListNode(list2.val);
				list2 = list2.next;
				current = current.next;
			}

			return dummy.next;
		}


		/********************************************/

		//leet code problem 148
		public ListNode SortList(ListNode head)
		{
			return MergeSort(head);
		}

		private ListNode MergeSort(ListNode head)
		{
			if (head == null || head.next == null) return head;

			ListNode midNode = MiddleNodeForMergeSort(head);
			ListNode head2 = midNode.next;

			midNode.next = null;

			ListNode left = MergeSort(head);
			ListNode right = MergeSort(head2);

			return MergeTwoSortedLists(left, right);
		}

		public static ListNode MiddleNodeForMergeSort(ListNode head) 
		{
			ListNode fast = head;
			ListNode slow = head;

			fast = fast.next;
			while (fast != null && fast.next != null)
			{
				slow = slow.next;
				fast = fast.next.next;
			}
			return slow;
		}

		/********************************************/
		//leet code problem 2095

		//We don't need the middle node we need the previous node 
		//in case of odd and the first mid in case of even
		//So we will make fast has more step than slow
		public static ListNode DeleteMiddle(ListNode head)
		{
			if (head == null) return null;
			if (head.next == null) return null;

			ListNode slow = head;
			ListNode fast = head;

			fast = fast.next.next;
			while (fast != null && fast.next != null)
			{
				fast = fast.next.next;
				slow = slow.next;
			}

			slow.next = slow.next.next;
			return head;
		}

		/********************************************/
		//Merge Two unsorted lists into new sort list (Amazon Interview)
		public ListNode MergeTwoUnSortedLists(ListNode list1, ListNode list2)
		{ 
			ListNode left = MergeSort(list1);
			ListNode right = MergeSort(list2);
			return MergeTwoSortedLists(left, right);
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


	}
}
