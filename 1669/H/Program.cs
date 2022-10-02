using System;
using System.Collections.Generic;

namespace H
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int n;
            long k;
            string[] input;
            List<long> ans = new List<long>();
            for (int i = 0; i < t; i++)
            {
                input = Console.ReadLine().Split();
                n = int.Parse(input[0]);
                k = long.Parse(input[1]);
                input = Console.ReadLine().Split();
                long[] array = new long[n];
                for (int j = 0; j < n; j++)
                {
                    array[j] = long.Parse(input[j]);
                }
                long answer = 0;
                for (int j = 30; j >= 0; j--)
                {
                    long count = 0, hold = (long)Math.Pow(2, j);
                    for (int u = 0; u < n; u++)
                    {
                        if ((array[u] & hold) == 0)
                            count++;
                    }
                    if (count <= k)
                    {
                        k -= count;
                        answer += hold;
                    }
                }
                ans.Add(answer);
            }
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
