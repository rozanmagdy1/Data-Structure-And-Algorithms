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
	}
}
