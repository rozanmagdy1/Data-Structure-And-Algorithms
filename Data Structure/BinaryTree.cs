namespace Data_Structure
{
	internal class BinaryTree
	{
		public class TreeNode
		{
			public int val;
			public TreeNode? left;
			public TreeNode? right;
			public TreeNode(int k)
			{
				val = k;
				left = right = null;
			}
		}

		//tree traversal
		//Breadth First Traversal
		public static IList<IList<int>> BFT(TreeNode root) 
			//Also called level order traversal
		{
			IList<IList<int>> levels = new List<IList<int>>();

			if (root != null)
			{
				Queue<TreeNode> q = new Queue<TreeNode>();
				q.Enqueue(root);

				while (q.Count > 0)
				{
					List<int> sublist = new List<int>();
					int levelCount = q.Count;
					for(int i = 0; i < levelCount; i++)
					{
						TreeNode current = q.Dequeue();
						sublist.Add(current.val);

						if(current.left != null) q.Enqueue(current.left);
						if(current.right != null) q.Enqueue(current.right);
					}
					levels.Add(sublist);
				}
			}
			return levels;

		}


		//Depth First Traversal

	}
}
