using System;
using System.Collections.Generic;
using System.Linq;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<long> ans = new List<long>();
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                string[] input = Console.ReadLine().Split();
                long pos = 0;
                long neg = 0;
                for (int j = 0; j < n; j++)
                {
                    long hold = long.Parse(input[j]);
                    if (hold >= 0)
                        pos += hold;
                    else
                        neg += hold;
                }
                neg *= -1;
                if (neg > pos)
                    ans.Add(neg - pos);
                else
                    ans.Add(pos - neg);

            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(ans[i]);
            }
        }
    }
}
