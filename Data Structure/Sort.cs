namespace Data_Structure
{
	internal class Sort
	{
		//Selection sort
		public static int[] SelectionSort(int[] arr)
		{
			for (int i = 0; i < arr.Length - 2; i++)
			{
				int min_index = i;
				for (int j = i + 1; j < arr.Length; j++)
				{
					if (arr[min_index] > arr[j])
					{
						min_index = j;
					}
				}

				int temp = arr[i];
				arr[i] = arr[min_index];
				arr[min_index] = temp;
			}
			return arr;
		}


		//Bubble sort
		public static int[] BubbleSort(int[] arr)
		{
			for (int i = 0; i < arr.Length - 1; i++)
			{
				for (int j = 0; j < arr.Length - i - 1; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						int temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
					}
				}
			}
			return arr;
		}


		//Insertion sort
		public static int[] InsertionSort(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				int j = i - 1;
				int temp = arr[i];

				while (arr[i] < arr[j] && j >= 0)
				{
					arr[j + 1] = arr[j];
					--j;
				}
				arr[j + 1] = temp;
			}
			return arr;

		}

		//Merge sort
		public static void MergeSort(int[] arr, int low, int high)
		{
			if (low >= high) return;
			int mid = low + (high - low) / 2;
			MergeSort(arr, low, mid);
			MergeSort(arr, mid + 1, high);
			Merge(arr, low, mid, high);
		}

		public static void Merge(int[] arr, int low, int mid, int high)
		{
			List<int> temp = new List<int>();
			int left = low;
			int right = mid + 1;

			while (left <= mid && right <= high)
			{
				if(arr[left] <= arr[right])
				{
					temp.Add(arr[left]);
					left++;
				} else
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

			for(int i = low; i <= high; i++)
			{
				arr[i] = temp[i - low];
			}

		}

	}
}
