using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            List<Tuple<int, int>> polices = new List<Tuple<int, int>>();
            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split();
                int l = int.Parse(input[0]);
                int r = int.Parse(input[1]);
                polices.Add(new Tuple<int, int>(l, r));
            }
            polices = polices.OrderBy(x => x.Item1).ThenByDescending(x => x.Item2).ToList();
            int checker = polices[0].Item1;
            int[] lenght = new int[n + 1];
            for (int i = 1; i < checker; i++)
                lenght[i] = i - 1;
            foreach(var police in polices)
            {
                while(checker <= police.Item1)
                {
                    lenght[checker] = checker - 1;
                    checker++;
                }
                while(checker <= police.Item2)
                {
                    lenght[checker] = police.Item1 - 1;
                    checker++;
                }
            }
            while(checker <= n)
            {
                lenght[checker] = checker - 1;
                checker++;
            }

            int[] ans = new int[n + 1];
            for (int i = 1; i <= n; i++)
                ans[i] = ans[lenght[i]] + 1;
            
            Console.WriteLine(ans[n]);
        }
    }
}
