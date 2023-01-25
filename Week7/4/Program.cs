using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int[] array = new int[n];
            for (int i = 0; i < n; i++) array[i] = int.Parse(input[i]);
            int q = int.Parse(Console.ReadLine());
            long[,] dp = new long[n + 1, 24];
            for (int i = 0; i < q; i++)
            {
                input = Console.ReadLine().Split();
                long s = long.Parse(input[0]) - 1;
                long k = long.Parse(input[1]);
                long sum = 0;
                if (k > 23)
                    for (int j = 0; (s + j * k) < n; j++) sum += array[s + j * k];
                else
                    sum = calSum(s, k, n, array, dp);
                Console.WriteLine(sum);
            }
        }
        public static long calSum(long s, long k, int n, int[] array, long[,] dp)
        {
            if (s >= n)
                return 0;
            if (dp[s, k] != 0)
                return dp[s, k];
            return dp[s, k] = array[s] + calSum(s + k, k, n, array, dp);
        }
    }
}
