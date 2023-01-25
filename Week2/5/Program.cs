using System;
using System.Collections.Generic;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            input = Console.ReadLine().Split();
            List<int> array = new List<int>();
            for (int i = 0; i < k; i++)
            {
                array.Add(int.Parse(input[i]));
            }
            long[,] dp = new long[k, k];
            long[,] sum = new long[k, k];
            for (int i = 0; i < k - 1; i++)
            {
                dp[i, i + 1] = array[i] + array[i + 1];
                sum[i, i + 1] = dp[i , i + 1];

                dp[i, i] = 0;
                sum[i, i] = array[i];
            }
            dp[k - 1, k - 1] = 0;
            sum[k - 1, k - 1] = array[k - 1];

            int temp = k - 2;
            for (int i = 0; i < k - 2; i++)
            {
                for (int j = 0; j < temp; j++)
                {
                    dp[j, k - temp + j] = min(dp, j, k - temp + j, sum);
                    long hold = sum[j, k - temp + j - 1] + array[k - temp + j];
                    sum[j, k - temp + j] = hold;
                }
                temp--;
            }
            Console.WriteLine(dp[0, k - 1]);
        }
        public static long min(long[,] dp, int i, int j, long[,] sum)
        {
            long min = long.MaxValue;
            for (int k = 0; k < (j - i); k++)
            {
                long temp = dp[i, j - k - 1] + dp[j - k, j] + sum[i, j - k - 1] + sum[j - k, j];
                min = Math.Min(min, temp);
            }
            return min;
        }
    }
}
