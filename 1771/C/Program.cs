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
                long[] array = new long[n];
                for (int j = 0; j < n; j++)
                {
                    array[j] = long.Parse(input[j]);
                }
                for (int j = 0; j < n; j++)
                {

                }
            }
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
