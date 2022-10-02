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
                int n = int.Parse(Console.ReadLine()) - 6;
                ans.Add(n / 3);
            }
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
