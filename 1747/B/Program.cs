using System;
using System.Collections.Generic;
using System.Linq;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<int> ans = new List<int>();
            List<int[]> swaps = new List<int[]>();
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int strt = 1, end = 3 * n, hold = 3 * n;
                int count = 0;
                while(hold > 0)
                {
                    count++;
                    swaps.Add(new int[] { strt, end });
                    strt += 3;
                    end -= 3;
                    hold -= 6;
                }
                ans.Add(count);
            }
            int temp = 0;
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(ans[i]);
                for (int j = 0; j < ans[i]; j++)
                {
                    Console.WriteLine(swaps[temp + j][0] + " " + swaps[temp + j][1]);
                }
                temp += ans[i];
            }
        }
    }
}
