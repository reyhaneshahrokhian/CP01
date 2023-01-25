using System;
using System.Collections.Generic;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<int> ans = new List<int>();
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int[] array = new int[n];
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    array[j] = int.Parse(input[j]);
                }
                int gcd;
                if (n > 1)
                {
                    gcd = GCD(array[0], array[1]);
                }
                else
                {
                    gcd = array[0];
                }
                for (int j = 2; j < n; j++)
                {
                    gcd = GCD(gcd, array[j]);
                }
                int answer = 0;
                if(gcd != 1)
                {
                    if (GCD(n, gcd) == 1 && array[n - 1] != 1)
                    {
                        answer = 1;
                    }
                    else if (GCD(n - 1, gcd) == 1 && array[n - 2] != 1)
                    {
                        answer = 2;
                    }
                    else
                        answer = 3;
                }
                ans.Add(answer);
            }
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
        public static int GCD(int x, int y)
        {
            if (x == 0)
                return y;

            return GCD(y % x, x);
        }
    }
}
