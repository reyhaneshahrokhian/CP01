using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[] numbers = new int[n+ 1];
            for (int i = 0; i < n; i++)
            {
                numbers[i + 1] = int.Parse(Console.ReadLine());
            }
            int[,] dp = new int[m + 1,n + 1];
            dp[0, 0] = 0;
            for (int i = 1; i <= m; i++)
            {
                dp[i,0] = 1000000000;
            }
            for (int j = 1; j <= n; j++)
            {
                for (int i = 0; i <= m; i++)
                {
                    dp[i,j] = 1000000000;
                    for (int k = 1; k * k <= i; k++)
                    {
                        dp[i, j] = Math.Min(dp[i, j], dp[i - k * k, j - 1] + (numbers[j] - k) * (numbers[j] - k));
                    }
                }
            }
            if (dp[m, n] == 1000000000)
                Console.WriteLine(-1);
            else
                Console.WriteLine(dp[m, n]);
        }
    }
}
