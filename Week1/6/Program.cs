using System;
using System.Collections.Generic;
using System.Linq;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            List<List<int>> options = new List<List<int>>();
            int p, c;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                p = int.Parse(input[0]);
                c = int.Parse(input[1]);
                options.Add(new List<int>() { p, c });
            }
            long max = long.MinValue;
            for (int i = 0; i < n; i++)
            {
                long hold = (options[0][1] + m) / options[0][0] + 1;
                max = Math.Max(max, hold);
            }
            long min = 1;
            long result = 1;
            while (min <= max)
            {
                long mid = min + (max - min) / 2;
                if (IsOk(options, mid, n, m))
                {
                    result = mid;
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            Console.WriteLine(result);
        }
        static bool IsOk(List<List<int>> options, long day, int n, int m)
        {
            long hold = 0;
            for (int i = 0; i < n; i++)
            {
                if(day * options[i][0] > options[i][1])
                {
                    hold += day * options[i][0] - options[i][1];
                }
            }
            if (hold >= m)
                return true;
            return false;
        }
    }
}
