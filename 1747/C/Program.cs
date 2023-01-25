using System;
using System.Collections.Generic;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<string> ans = new List<string>();
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                string[] input = Console.ReadLine().Split();
                long sumO = 0, sumE = 0, first = long.Parse(input[0]);
                for (int j = 0; j < n; j++)
                {
                    long hold = long.Parse(input[j]);
                    if (hold % 2 == 0)
                        sumE += hold;
                    else
                        sumO += hold;
                }
                if (sumO > sumE)
                    ans.Add("Bob");
                else if (sumE > sumO)
                    ans.Add("Alice");
                else
                {
                    if(first % 2 == 0)
                        ans.Add("Bob");
                    else
                        ans.Add("Alice");
                }
            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(ans[i]);
            }
        }
    }
}
