using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int k = int.Parse(input[2]);
            input = Console.ReadLine().Split();
            int[] satisfictions = new int[n + 1];
            int[,] rules = new int[n + 1, n + 1];
            for (int i = 0; i < n; i++)
            {
                satisfictions[i + 1] = int.Parse(input[i]);
            }
            for (int i = 0; i < k; i++)
            {
                input = Console.ReadLine().Split();
                rules[int.Parse(input[0]), int.Parse(input[1])] = int.Parse(input[2]);
            }

            long[,] dp = new long[(1 << n) + 1, n + 1];
            long ans = 0;
            for (int i = 1; i <= n; i++)
            {
                dp[(1 << (i - 1)), i] = satisfictions[i];
            }
            for (int mask = 1; mask < (1 << n); mask++)
            {
                int hold = 0;
                for (int i = 1; i <= n; i++)
                {
                    if ((mask & (1 << (i - 1))) != 0)
                    {
                        hold++;
                        for (int j = 1; j <= n; j++)
                        {
                            if (i != j && (mask & (1 << (j - 1))) == 0)
                            {
                                dp[mask | (1 << (j - 1)), j] = Math.Max(dp[mask | (1 << (j - 1)), j], dp[mask, i] + rules[i, j] + satisfictions[j]);
                            }
                        }
                    }
                }
                if (hold == m)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        if ((mask & (1 << (i - 1))) != 0)
                            ans = Math.Max(ans, dp[mask, i]);
                    }
                }
            }
/*            for (int i = 0; i <= (int)Math.Pow(2, n); i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    Console.Write(dp[i, j]);
                }
                Console.WriteLine();
            }*/
            Console.WriteLine(ans);
        }
    }
}
