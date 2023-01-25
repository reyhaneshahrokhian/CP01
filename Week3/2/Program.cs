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
            List<Tuple<int, int, int>> graph = new List<Tuple<int, int, int>>();
            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split();
                graph.Add(new Tuple<int, int, int>(int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3])));
            }
            graph = graph.OrderBy(x => x.Item3).ToList();
            graph.Add(new Tuple<int, int, int>(0, 0, 0));
            int[] dp = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                dp[i] = 0;
            }
            for (int i = 0; i < m; i++)
            {
                List<int> temps = new List<int>();
                int count = 0;
                while (graph[i + count].Item3 == graph[i].Item3)
                {
                    temps.Add(Math.Max(dp[graph[i + count].Item2], dp[graph[i + count].Item1] + 1));
                    count++;
                }
                for (int j = 0; j < temps.Count; j++)
                {
                    dp[graph[i].Item2] = temps[j];
                    i++;
                }
                i--;
            }
            int max = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                //Console.WriteLine(dp[i]);
                max = Math.Max(max, dp[i]);
            }
            Console.WriteLine(max);
        }
    }
}
