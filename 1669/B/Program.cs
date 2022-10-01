using System;
using System.Collections.Generic;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m;
            string[] input;
            List<int> ans = new List<int>();

            for (int i = 0; i < n; i++)
            {
                m = int.Parse(Console.ReadLine());
                input = Console.ReadLine().Split();
                int[] count = new int[m + 1];
                bool flag = false;

                for (int j = 0; j < m; j++)
                {
                    count[int.Parse(input[j])]++;
                }
                for (int j = 0; j <= m; j++)
                {
                    if (count[j] > 2)
                    {
                        flag = true;
                        ans.Add(j);
                        break;
                    }
                }
                if (!flag)
                    ans.Add(-1);
            }
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
