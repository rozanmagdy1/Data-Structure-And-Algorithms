using Data_Structure;
using Data_Structure.Problems;
using static Data_Structure.BinaryTree;

//Sort
//Sort.MergeSort(new int[] {5, 2, 3, 1, 4}, 0, 4);

//Numeric Problems
//NumericProblems.Power(3, 3);



//Linked List problems
//ListNode node1 = new ListNode(1);
//ListNode node2 = new ListNode(1);
//ListNode node3 = new ListNode(2);
//ListNode node4 = new ListNode(1);
//node1.next = node2;
//node2.next = node3;
//node3.next = node4;

//LinkedListProblems.IsPalindrome(node1);


//Array Problems
//ArrayProblems.Merge(new int[] { 0 }, 0, new int[] { 1 }, 1);


//Tree Problems
TreeNode root = new TreeNode(3);
root.left = new TreeNode(9);
root.right = new TreeNode(20);
root.right.left = new TreeNode(15);
root.right.right = new TreeNode(7);
BinaryTree.BFT(root);