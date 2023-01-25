using System;

namespace _4
{
    class Program
    {
        public static long mod = (long)Math.Pow(10, 9) + 7;
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int k = int.Parse(input[2]);

            int x;
            if (k == 1 || n < k) x = n;
            else if (n == k) x = (n + 1) / 2;
            else x = 1 + k % 2;

            Console.WriteLine(pow(m, x));
        }
        public static long pow(int a, int b)
        {
            long ans = 1;
            for (int i = 0; i < b; i++)
            {
                ans *= a;
                ans %= mod;
            }
            return ans;
        }
    }
}
