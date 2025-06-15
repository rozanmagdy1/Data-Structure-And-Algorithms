namespace Data_Structure
{
	internal class ArrayProblems
	{
		//leet code problem 4
		public static double FindMedianSortedArrays(int[] nums1, int[] nums2) //[1,2]  //[3,4]
		{
			int n = nums1.Length;
			int m = nums2.Length;

			int[] mergedArray = new int[n + m]; //[1, 2, 3, 4]

			//merge two arrays
			int temp1 = 0, temp2 = 0, temp3 = 0;

			while (temp1 < n && temp2 < m)
			{
				if (nums1[temp1] <= nums2[temp2])
				{
					mergedArray[temp3++] = nums1[temp1++];
				}
				else
				{
					mergedArray[temp3++] = nums2[temp2++];
				}
			}

			while (temp1 < n)
			{
				mergedArray[temp3++] = nums1[temp1++];
			}

			while (temp2 < m)
			{
				mergedArray[temp3++] = nums2[temp2++];
			}

			//find median
			double median;
			int midIndex = 0 + ((mergedArray.Length - 1) - 0) / 2;

			if (mergedArray.Length % 2 == 0)
			{
				median = (mergedArray[midIndex] + mergedArray[midIndex + 1]) / 2.0;
			}
			else
			{
				median = mergedArray[midIndex];
			}
			return median;
		}

		/************************************************/

		//leet code problem215 

		public static int FindKthLargest(int[] nums, int k)
		{
			SortArray(nums);
			int index = nums.Length - k;
			return nums[index];
		}

		/************************************************/
		//leet code 75  
		public static void SortArray(int[] arr)
		{
			MergeSort(arr, 0, arr.Length - 1);
		}

		private static void MergeSort(int[] arr, int low, int high)
		{
			if (low >= high) return;
			int mid = low + (high - low) / 2;

			MergeSort(arr, low, mid);
			MergeSort(arr, mid + 1, high);
			Merge(arr, low, mid, high);
		}

		private static void Merge(int[] arr, int low, int mid, int high)
		{
			int left = low;
			int right = mid + 1;
			List<int> temp = new List<int>();

			while (left <= mid && right <= high)
			{
				if (arr[left] <= arr[right])
				{
					temp.Add(arr[left]);
					left++;
				}
				else
				{
					temp.Add(arr[right]);
					right++;
				}
			}

			while (left <= mid)
			{
				temp.Add(arr[left]);
				left++;
			}

			while (right <= high)
			{
				temp.Add(arr[right]);
				right++;
			}

			for (int i = low; i <= high; i++)
			{
				arr[i] = temp[i - low];
			}
		}
		public void SortColors(int[] nums)
		{
			SortArray(nums);
		}

		/************************************************/

		//Find median of array
		public static double FindMedian(int[] arr)
		{
			SortArray(arr);

			int low = 0;
			int high = arr.Length - 1;
			int midIndex = low + (high - low) / 2;

			double median;
			if (arr.Length % 2 == 0) //even
			{
				median = (arr[midIndex] + arr[midIndex + 1]) / 2.0;
			}
			else //odd
			{
				median = arr[midIndex];
			}

			return median;
		}

		/************************************************/

		//Merge two unsorted array  
		public static int[] MergeTwoUnsortedArrays(int[] nums1, int[] nums2)
		{
			MergeSort(nums1, 0, nums1.Length - 1);
			MergeSort(nums2, 0, nums2.Length - 1);
			return MergeTwoSortedArrays(nums1, nums2);
		}

		/********************************************/

		//Merge two sorted array  
		public static int[] MergeTwoSortedArrays(int[] nums1, int[] nums2)
		{
			int n = nums1.Length;
			int m = nums2.Length;

			int[] mergedArray = new int[n + m]; //[1, 2, 3, 4]

			//merge two arrays
			int temp1 = 0, temp2 = 0, temp3 = 0;

			while (temp1 < n && temp2 < m)
			{
				if (nums1[temp1] <= nums2[temp2])
				{
					mergedArray[temp3++] = nums1[temp1++];
				}
				else
				{
					mergedArray[temp3++] = nums2[temp2++];
				}
			}

			while (temp1 < n)
			{
				mergedArray[temp3++] = nums1[temp1++];
			}

			while (temp2 < m)
			{
				mergedArray[temp3++] = nums2[temp2++];
			}
			return mergedArray;
		}

		/********************************************/

		//leet code problem 442
		public IList<int> FindDuplicates(int[] nums)
		{
			Dictionary<int, int> map = new Dictionary<int, int>();

			int newLength = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				if (map.ContainsKey(nums[i]))
				{
					map[nums[i]]++;
					newLength++;
				}
				else
				{
					map[nums[i]] = 1;
				}
			}
			nums = new int[newLength];
			int count = 0;
			foreach (var ma in map)
			{
				if (ma.Value == 2)
				{
					nums[count++] = ma.Key;
				}
			}
			return nums;

		}

		/************************************************/

		//leet code problem 26
		public int RemoveDuplicates(int[] nums) //remove duplicates from sorted array 
		{
			int newLength = 0;
			int current = int.MinValue;
			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] != current)
				{
					nums[newLength++] = nums[i];
				}

				current = nums[i];
			}
			return newLength;
		}

		/************************************************/

		//leet code problem 27
		public int RemoveElement(int[] nums, int val)
		{
			int newLength = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] != val)
				{
					nums[newLength++] = nums[i];
				}
			}
			return newLength;

		}

		/********************************************/

		//leet code problem 347    
		public static int[] TopKFrequent(int[] nums, int k)
		//[1,1,1,2,2,3], k = 2
		{
			//Create map to put frequencies 
			Dictionary<int, int> map = new Dictionary<int, int>();
			for (int i = 0; i < nums.Length; i++)
			{
				if (map.ContainsKey(nums[i]))
				{
					map[nums[i]]++;
				}
				else
				{
					map[nums[i]] = 1;
				}
			}

			//Make bucket sort
			List<int>[] buckets = new List<int>[nums.Length + 1];
			foreach (var item in map)
			{
				if (buckets[item.Value] == null)
				{
					buckets[item.Value] = new List<int>();
				}
				buckets[item.Value].Add(item.Key);
			}

			List<int> result = new List<int>();

			//Get the top k
			int numberAdded = 0;
			for (int i = buckets.Length - 1; i >= 0; i--)
			{
				if (buckets[i] == null) continue;
				if (numberAdded < k)
				{
					result.AddRange(buckets[i]);
					numberAdded += buckets[i].Count;
				}
				else
				{
					break;
				}

			}

			return result.ToArray();
		}

		/************************************************/

		//leet code problem 88
		//public static void Merge(int[] nums1, int m, int[] nums2, int n)
		//{


		//}


		/************************************************/
		//leet code problem 88
		//public int[] TwoSum(int[] nums, int target)
		//{

		//}

		/************************************************/

		//leet code problem 53
		public int MaxSubArray(int[] nums)
		{   //[-2,1,-3,4,-1,2,1,-5,4]

			//Brute force algorithm
			//int max_sum = int.MinValue;
			//for (int i = 0; i < nums.Length; i++)
			//{
			//	int j = i;
			//	int current_sum = 0;
			//	while (j < nums.Length)
			//	{
			//		current_sum += nums[j];
			//		if (current_sum > max_sum)
			//		{
			//			max_sum = current_sum;
			//		}
			//		j++;
			//	}
			//}
			//return max_sum;

			//Dynamic Programming O(n)
			int max_sum = int.MinValue;
			int current = 0;
			int start_index = 0, last_index = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				if (current == 0) start_index = i;
				current += nums[i];
				if (max_sum < current)
				{
					max_sum = current;
					last_index = i;
				}

				if (current < 0)
				{
					current = 0;
				}

			}
			int[] subarray = nums.Skip(start_index).Take((last_index - start_index) + 1).ToArray();
			for (int i = 0; i < subarray.Length; i++)
			{
				Console.WriteLine(subarray[i]);
			}
			return max_sum;

			//return GetMaxSubarraySum(nums, 0, nums.Length - 1);


		}
		private int GetMaxSubarraySum(int[] nums, int low, int high)
		{
			if(low >= high) return nums[low];
			int mid = low + (high - low) / 2;
			int left = GetMaxSubarraySum(nums, low, mid);
			int right = GetMaxSubarraySum(nums, mid + 1, high);
			int cross = CrossSum(nums, low, mid, high);
			return Math.Max(Math.Max(left, right), cross);
		}

		private int CrossSum(int[] nums, int low, int mid, int high) {
			int current = 0;

			int max_left = int.MinValue;
			// for (int i = low; i <= mid; i++)
			// {
			//     current += nums[i];
			//     if (current > max_left) max_left = current;
			// }

			for (int i = mid; i >= low; i--)
			{
				current += nums[i];
				if (current > max_left) max_left = current;
			}

			current = 0;
			int max_right = int.MinValue;
			for (int i = mid + 1; i <= high; i++)
			{
				current += nums[i];
				if (current > max_right) max_right = current;
			}
			return max_right + max_left;
		}

		/************************************************/



	}
}
