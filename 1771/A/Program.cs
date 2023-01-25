using System;
using System.Collections.Generic;

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
                int[] array = new int[n];
                int min = int.MaxValue;
                int max = int.MinValue;
                for (int j = 0; j < n; j++)
                {
                    array[j] = int.Parse(input[j]);
                    min = Math.Min(min, array[j]);
                    max = Math.Max(max, array[j]);
                }
                long countmin = 0;
                long countmax = 0;
                for (int j = 0; j < n; j++)
                {
                    if (array[j] == min) countmin++;
                    if (array[j] == max) countmax++;
                }
                if(min == max) ans.Add(countmin * (countmin - 1));                
                else ans.Add(countmax * countmin * 2);
            }
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
