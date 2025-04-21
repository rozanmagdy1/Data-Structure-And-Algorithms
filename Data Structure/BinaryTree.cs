namespace Data_Structure
{
	internal class BinaryTree
	{
		public class Node
		{
			public int key;
			public Node left, right;
			public Node(int k)
			{
				key = k;
				left = right = null;
			}
		}

		Node root;
		public BinaryTree(int key)
		{
			root = new Node(key);
		}
		public BinaryTree()
		{
			root = null;
		}
		public void PreOrder(Node node)
		{
			Console.WriteLine(node.key);
			PreOrder(node.left);
			PreOrder(node.right);

		}

		public void InOrder()
		{

		}

		public void PostOrder()
		{

		}

		public void BFS()
		{
			if (root == null) return;

			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(root);

			while (queue.Count > 0)
			{
				Node current = queue.Dequeue();
				Console.Write(current.key + " ");

				if (current.left != null) queue.Enqueue(current.left);
				if (current.right != null) queue.Enqueue(current.right);
			}
		}
	}
}
