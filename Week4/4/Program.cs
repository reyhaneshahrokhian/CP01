using System;
using System.Collections.Generic;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            List<List<int>> graph = new List<List<int>>();
            for (int i = 0; i <= n; i++)
            {
                graph.Add(new List<int>());
            }
            for (int i = 0; i < n - 1; i++)
            {
                input = Console.ReadLine().Split();
                graph[int.Parse(input[0])].Add(int.Parse(input[1]));
                graph[int.Parse(input[1])].Add(int.Parse(input[0]));
            }
            long[,] dp = new long[n + 1, k + 1];
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    dp[i, j] = -1;
                }
            }
            long[] parents = new long[n + 1];
            dfs1(1, 0, parents, graph);
            long ans = 0;
            for (int i = 1; i <= n; i++)
            {
                long a = dfs2(i, k, (int)parents[i], dp, graph), b = 0;
                for (int j = 0; j < graph[i].Count; j++)
                {
                    if (graph[i][j] != parents[i])
                    {
                        for (int x = 1; x < k; x++)
                        {
                            b += (dfs2(graph[i][j], x - 1, i, dp, graph) * (dfs2(i, k - x, (int)parents[i], dp, graph) - dfs2(graph[i][j], k - x - 1, i, dp, graph)));
                        }
                    }
                }
                ans += (a + b / 2);
            }
            Console.WriteLine(ans);
        }
        public static void dfs1(int n, int count, long[] parents, List<List<int>> graph)
        {
            parents[n] = count;
            for (int i = 0; i < graph[n].Count; i++)
            {
                if(graph[n][i] != count)
                {
                    dfs1(graph[n][i], n, parents, graph);
                }
            }
        }
        public static long dfs2(int n, int k, int count, long[,] dp, List<List<int>> graph)
        {
            long ans = 0;
            if (dp[n, k] != -1)
                return dp[n,k];
            
            else if (k == 0) 
                ans = 1;
            else
                for (int i = 0; i < graph[n].Count; i++)
                {
                    if (graph[n][i] != count)
                        ans += dfs2(graph[n][i], k - 1, n, dp, graph);                   
                }

            return dp[n, k] = ans;
        }
    }
}
