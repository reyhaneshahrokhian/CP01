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
                if (n < 10) ans.Add(n);
                else if (n <= 100) ans.Add(n / 10 + 9);
                else if (n <= 1000) ans.Add(n / 100 + 18);
                else if (n <= 10000) ans.Add(n / 1000 + 27);
                else if (n <= 100000) ans.Add(n / 10000 + 36);
                else if (n <= 1000000) ans.Add(n / 100000 + 45);
            }
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
