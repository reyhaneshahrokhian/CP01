using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            long[] array = new long[(int)n];
            for (int i = 0; i < (int)n; i++)
            {
                array[i] = long.Parse(input[i]);
            }
            Console.WriteLine(Solve(n, array));
        }
        public static long Solve(long n, long[] a)
        {
            long max = a[0], hold = 0;

            for (long i = 0; i < n; i++)
            {
                hold += a[i];
                if (hold < 0)
                    hold = 0;
                else if (max < hold)
                    max = hold;
            }
            return max;
        }
    }
}
