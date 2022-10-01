using System;
using System.Collections.Generic;

namespace F
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int n;
            string[] input;
            List<long> ans = new List<long>();
            for (int i = 0; i < t; i++)
            {
                n = int.Parse(Console.ReadLine());
                input = Console.ReadLine().Split();
                int[] array = new int[n];
                for (int j = 0; j < n; j++)
                {
                    array[j] = int.Parse(input[j]);
                }
                int answer = 0, count = 2, l = 0, r = n - 1;
                long a = array[l], b = array[r];
                while (l < r)
                {
                    if(a > b)
                    {
                        r--;
                        b += array[r];
                        count++;
                    }
                    else if( b > a)
                    {
                        l++;
                        a += array[l];
                        count++;
                    }
                    else
                    {
                        r--;
                        l++;
                        a += array[l];
                        b += array[r];
                        answer = count;
                        count += 2;
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
