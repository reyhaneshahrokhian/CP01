using System;
using System.Collections.Generic;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<int> ans = new List<int>();
            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split();
                int n = int.Parse(input[0]);
                input = Console.ReadLine().Split();
                int[] array = new int[n];
                for (int j = 0; j < n; j++)
                {
                    array[j] = int.Parse(input[j]);
                }
                Console.ReadLine();
                ans.Add(Solve(n, array));
            }
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
        public static int Solve(int n, int[] a)
        {
            int max = a[0], hold = 0;
            int xor = a[0], holdx = 0;
            for (int i = 0; i < n; i++)
            {
                holdx ^= a[i];
                hold += a[i];
                if (hold < 0)
                {
                    hold = 0;
                    holdx = 0;
                }
                else if (max < hold)
                {
                    max = hold;
                    xor = holdx;
                }
            }
            return xor;
        }
    }
}
