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
                string[] input = Console.ReadLine().Split();
                n = 10 - n;
                ans.Add(n * (n - 1) * 3);
            }
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
