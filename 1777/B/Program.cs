using System;

namespace B
{
    class Program
    {
        public static long mode = 1000000007;
        static void Main(string[] args)
        {
            
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                long ans = fact(n);
                ans *= n;
                ans %= mode;
                ans *= (n - 1);
                ans %= mode;
                Console.WriteLine(ans);
            }
        }
        public static long fact(int n)
        {
            long ans = 1;
            for (int i = 2; i <= n; i++)
            {
                ans *= i;
                ans %= mode;
            }
            return ans;
        }
    }
}
