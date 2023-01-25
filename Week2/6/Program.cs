using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                array1[i] = int.Parse(input[i]);
            }
            input = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                array2[i] = int.Parse(input[i]);
            }
            long[,] dp = new long[n, 3];
            dp[0, 0] = array1[0];
            dp[0, 1] = array2[0];
            dp[0, 2] = 0;
            for (int i = 1; i < n; i++)
            {
                dp[i, 0] = Math.Max(dp[i - 1, 1], dp[i - 1, 2]) + array1[i];
                dp[i, 1] = Math.Max(dp[i - 1, 0], dp[i - 1, 2]) + array2[i];
                dp[i, 2] = Math.Max(Math.Max(dp[i - 1, 0], dp[i - 1, 1]), dp[i - 1, 2]);
            }
            Console.WriteLine(Math.Max(Math.Max(dp[n - 1, 0], dp[n - 1, 1]), dp[n - 1, 2]));
        }
    }
}
