namespace Data_Structure
{
	internal class ArrayProblems
	{
		public static int[] TwoSum(int[] nums, int target)
		{
			//O(n^2)
			for (int i = 0; i < nums.Length; i++)
			{
				int j = i + 1;
				while (j < nums.Length)
				{
					if (nums[i] + nums[j] == target)
					{
						return new int[] { i, j };
					}
					j++;
				}
			}
			return new int[] { 0, 0 };

			//using hashmap

		}

		public bool TwoSumBool(int[] nums, int target)
		{
			//O(n) using hashset //[2,7,11,15]  target = 9
			//HashSet<int> set = new HashSet<int>(); 

			//for (int i = 0; i < nums.Length; i++)
			//{
			//	int complentary = target - nums[i];
			//	if (set.Contains(complentary))
			//	{
			//		return true;
			//	}
			//	else
			//	{
			//		set.Add(nums[i]);
			//	}
			//}
			//return false;

			//O(1) using two pointers
			Array.Sort(nums);
			int left = 0;
			int right = nums.Length - 1;

			while (left < right)
			{
				int sum = nums[left] + nums[right];

				if (sum == target)
				{
					return true;
				}
				else if (sum < target)
				{
					left++;
				}
				else
				{
					right--;
				}
			}
			return false;
		}
	}
}
