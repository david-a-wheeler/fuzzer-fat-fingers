using System;

namespace ZigZagTest
{

	class ZigZagTest
	{
	
		public static int[,] ZigZag(int n)
		{
			int[,] result = new int[n, n];
			int i = 0, j = 0;
			int d = -1; // -1 for top-right move, +1 for bottom-left move
			int start = 0, end = n * n - 1;
			do
			{
				result[i, j] = start++;
				result[n - i - 1, n - j - 1] = end--;
		 
				i += d; j -= d;
				if (i < 0)
				{
					i++; d = -d; // top reached, reverse
				}
				else if (j < 0)
				{
					j++; d = -d; // left reached, reverse
				}
			} while (start < end);
			if (start == end)
				result[i, j] = start;
			return result;
		}
		
		public static void Main(string[] args)
		{
			int n = 5;
			int[,] table = ZigZag(5);
			
			for(int row = 0; row < n; row++)
			{
				for(int col = 0; col < n; col++)
				{
					Console.Write("{0,5}", table[row, col]);
				}
				Console.WriteLine();
			}
		
		}
	}
	
}