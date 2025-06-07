using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Problems
{
	internal class StringProblems
	{
		public void ReverseString(char[] s)
		{
			int left = 0;
			int right = s.Length - 1;

			while (left < right)
			{
				char temp = s[left];
				s[left] = s[right];
				s[right] = temp;

				left++;
				right--;
			}
		}
	}
}
