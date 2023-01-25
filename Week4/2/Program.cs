using System;

namespace _2
{
    class Program
    {
        public static long mode = (long)Math.Pow(10, 9) + 7;
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long m = long.Parse(input[1]);
            long ans = (((fact(2 * m + n - 1) * calcSTH(fact(2 * m), mode - 2)) % mode) * calcSTH(fact(n - 1), mode - 2)) % mode;
            Console.WriteLine(ans);
        }
        public static long fact(long num)
        {
            long ans = 1;
            for (long i = 2; i <= num; i++)
            {
                ans *= i;
                ans %= mode;
            }
            return ans;
        }
        public static long calcSTH(long a, long b)
        {
            long ans = 1;
            while (b > 0)
            {
                if (b % 2 == 1)
                {
                    ans *= a;
                    ans %= mode;
                }
                b /= 2;
                a *= a;
                a %= mode;
            }
            return ans;
        }
    }
}
