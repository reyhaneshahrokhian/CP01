using System;
using System.Collections.Generic;

namespace B
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
                string[] input = Console.ReadLine().Split();
                int[] array = new int[n];
                int min = int.MaxValue, max = int.MinValue;
                for (int j = 0; j < n; j++)
                {
                    array[j] = int.Parse(input[j]);
                    min = Math.Min(min, array[j]);
                }
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (array[j] > min)
                    {
                        if((array[j] % (2 * min - 1)) == 0)
                            count += (array[j] / (2 * min - 1)) - 1;
                        
                        else
                            count += (array[j] / (2 *min - 1));
                    }
                }

                ans.Add(count);
            }
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
