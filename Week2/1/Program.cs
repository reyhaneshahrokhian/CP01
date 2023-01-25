using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            input = Console.ReadLine().Split();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(input[i]);
            }
            input = Console.ReadLine().Split();
            int[] b = new int[m];
            for (int i = 0; i < m; i++)
            {
                b[i] = int.Parse(input[i]);
            }
            int[,] dp = new int[n + 1, m + 1];
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= m; j++)
                {
                    if (i == 0 || j == 0)
                        dp[i, j] = 0;
                    else if (a[i - 1] == b[j - 1])
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    else
                        dp[i, j] = Math.Max(dp[i, j - 1], dp[i - 1, j]);
                }
            }
            /* for (int i = 0; i < n; i++)
             {
                 if (b[0] == a[i])
                 {
                     dp[i, 0] = 1;
                 }
             }
             for (int i = 0; i < m; i++)
             {
                 if (b[i] == a[0])
                 {
                     dp[0, i] = 1;
                 }
             }
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    if (a[i] == b[j])
                        dp[i, j] = dp[i - 1, j - 1] + 1;

                    else
                        dp[i, j] = Math.Max(dp[i, j - 1], dp[i - 1, j]);
                }
            }*/
            Console.WriteLine(dp[n, m]);
        }
    }
}
