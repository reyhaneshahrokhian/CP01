using System;
using System.Collections.Generic;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            string[] input;
            int n, m, a, b;
            List<int> ans = new List<int>();
            for (int i = 0; i < T; i++)
            {
                input = Console.ReadLine().Split();
                n = int.Parse(input[0]);
                m = int.Parse(input[1]);
                a = int.Parse(input[2]);
                b = int.Parse(input[3]);

                ans.Add(MinimumMoney(n, m, a, b));
            }
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
        public static int MinimumMoney(int n, int m, int a, int b)
        {
            int x = 0, y = 0;
            int countX = 0, countY = 0;
            while (x < (m - b + 1))
            {
                x += 2 * b - 1;
                countX++;
            }
            while (y < (n - a + 1))
            {
                y += 2 * a - 1;
                countY++;
            }
            return countX * countY;
        }
    }
}
