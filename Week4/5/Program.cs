using System;

namespace _5
{
    class Program
    {
        public static long mod = 998244353;
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long[] dp = new long[n + 1];
            dp[0] = 1;
            long fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = (fact * i) % mod;
                dp[i] = fact + ((dp[i - 1] - 1) * i) % mod;
                dp[i] %= mod;
            }
            Console.WriteLine(dp[n]);
        }
    }
}
