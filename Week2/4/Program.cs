using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int[] array = new int[n];
            input = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(input[i]);
            }
            long[,,] dp = new long[n, B + 1, 2];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= B; j++)
                {
                    dp[i, j, 0] = (long)Math.Pow(10, 13);
                    dp[i, j, 1] = (long)Math.Pow(10, 13);
                }
            }
            dp[0, B - 1, 0] = 0;
            dp[0, B, 1] = 0;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j <= B; j++)
                {
                    if (2 * B - i - j > 0)
                    {
                        if (j == B)
                        {
                            dp[i, j, 1] = dp[i - 1, j, 1];
                        }
                        else
                        {
                            dp[i, j, 0] = Math.Min(dp[i - 1, j + 1, 0], dp[i - 1, j + 1, 1] + array[i]);
                            dp[i, j, 1] = Math.Min(dp[i - 1, j, 1], dp[i - 1, j, 0] + array[i]);
                        }
                    }
                }
            }
            long ans = long.MaxValue;
            for (int i = 0; i <= B; i++)
            {
                //Console.WriteLine(dp[n - 1, i, 0] + " " + dp[n - 1, i, 1]);
                ans = Math.Min(ans, dp[n - 1, i, 0]);
                ans = Math.Min(ans, dp[n - 1, i, 1]);
            }
            Console.WriteLine(ans);
        }
    }
}
