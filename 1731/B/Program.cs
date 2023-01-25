using System;
using System.Numerics;

namespace B
{
    class Program
    {
        public static ulong mod = (ulong)Math.Pow(10, 9) + 7;
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                ulong n = ulong.Parse(Console.ReadLine());
                ulong ans = 0;
                ans += (((n * (n - 1)) % mod) * 1011) % mod;
                ans += (((((n * (2 * n - 1)) % mod) * (n - 1)) % mod) * 674) % mod;
                ans += ((n * n) % mod * 2022) % mod;
                ans %= mod;
                Console.WriteLine(ans);
            }
        }
    }
}
