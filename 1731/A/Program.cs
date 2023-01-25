using System;
using System.Collections.Generic;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                string[] input = Console.ReadLine().Split();
                long ans = 1;
                for (int j = 0; j < n; j++) ans *= long.Parse(input[j]);
                ans += (n - 1);
                Console.WriteLine(2022 * ans);
            }
        }
    }
}
