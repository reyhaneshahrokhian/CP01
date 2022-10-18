using System;
using System.Collections.Generic;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<int[]> ans = new List<int[]>();
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int[] array = new int[n];
                array[0] = 1;
                array[n - 1] = 2;
                int hold = 3;
                for (int k = 1; k < n - 1; k++)
                {
                    array[k] = hold;
                    hold++;
                }
                ans.Add(array);
            }
            foreach (var item in ans)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    Console.Write(item[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
