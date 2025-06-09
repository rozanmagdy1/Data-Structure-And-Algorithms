namespace Data_Structure.Problems
{
	internal class NumericProblems
	{
		//leet code problem 50
		public static double Power(double x, int n)
		{
			//Iterative time O(n) and space O(1)
			//double result = 1;
			//int iterativeCount = n >= 0 ? n :  -n;

			//for (int i = 0; i < iterativeCount; i++)
			//{
			//	result *= x;
			//}

			//return n >= 0 ? result : result == 0 ? result : 1 / result;

			//**********************************//

			//Recusrion time O(n) space O(n)
			//int iterativeCount = n >= 0 ? n : -n;
			//if (iterativeCount == 0) return 1;

			//double result = x * Power(x, iterativeCount - 1);
			//return n >= 0 ? result : result == 0 ? result : 1 / result;

			//**********************************//

			//Divide and Conquer time O(log n) space O(log n)
			int iterativeCount = n >= 0 ? n : -n;

			if (iterativeCount == 0) return 1;
			double half = Power(x, iterativeCount / 2);
			double result;
			if (n % 2 == 0)
			{
				result = half * half;
			}
			else
			{
				result = x * half * half;
			}
			return n >= 0 ? result : result == 0 ? result : 1 / result;
		}
	}
}
