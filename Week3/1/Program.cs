using System;
using System.Linq;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input;
            double[,] array = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = double.Parse(input[j]);
                }
            }
            int size = (int)Math.Pow(2, n);
            double[] dp = new double[size];
            dp[size - 1] = 1;
            for (int i = size - 1; i > 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    if (((i >> j) & 1) == 1)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            int temp = one_count(i);
                            if (j != k && ((i >> k) & 1) == 1)
                                dp[i & (~(1 << k))] += dp[i] * array[j, k] / (temp * (temp - 1) / 2);
                        }
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(string.Format("{0:n6}", dp[(int)Math.Pow(2, i)]) + " ");
            }
        }
        static int one_count(int indx)
        {
            int count = 0;
            while (indx > 0)
            {
                if (((indx >> 0) & 1) == 1)
                    count++;
                indx >>= 1;
            }
            return count;
        }
        public static double choose(int n, int k)
        {
            double ans = (double)fact(n) / ((double)fact(k) * (double)fact(n - k));
            return ans;
        }
        public static int fact(int n)
        {
            int ans = 1;
            while (n > 0)
            {
                ans *= n;
                n--;
            }
            return ans;
        }
    }
}
