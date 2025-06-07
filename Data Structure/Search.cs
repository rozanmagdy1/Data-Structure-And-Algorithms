namespace Data_Structure
{
	internal class Search
	{
		public int LinearSearch(int[] arr, int k)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == k)
				{
					return i;
				}
			}
			return -1;
		}
		public int BinarySearch(int[] arr, int k)
		{
			int low = 0;
			int high = arr.Length - 1;
			while (low <= high)
			{
				int mid = low + (high - low) / 2;
				if (k == arr[mid])
					return mid;

				else if (k > arr[mid]) //go larger
					low = mid + 1;

				else  //go smaller
					high = mid - 1;
			}
			return -1;
		}

		public int BinarySearchRecursive(int[] arr, int k, int low, int high)
		{
			while (low <= high)
			{
				int mid = low + (high - low) / 2;
				if (k == arr[mid])
					return mid;

				else if (k > arr[mid]) //go larger
					return BinarySearchRecursive(arr, k, mid + 1, high);

				else  //go smaller
					return BinarySearchRecursive(arr, k, low, mid - 1);
			}
			return -1;
		}
	}
}
