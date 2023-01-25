using System;
using System.Collections.Generic;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int q = int.Parse(input[1]);
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
            for (int i = 1; i <= n; i++)
            {
                graph.Add(i, new List<int>());
            }
            int[] parents = new int[n + 1];
            input = Console.ReadLine().Split();
            for (int i = 2; i <= n; i++) 
            {
                parents[i] = int.Parse(input[i - 2]);
                graph[parents[i]].Add(i);
            }
            bool[] visited = new bool[n + 1];
            int[] depth = new int[n + 1];
            dfs(1, visited, depth, parents, graph);

            int[,] dp = new int[n + 1, 21];
            for (int i = 1; i <= n; i++) 
                dp[i, 0] = parents[i];

            for (int i = 1; i <= n; i++) 
                for (int j = 1; j <= 20; j++)
                    dp[i, j] = dp[dp[i, j - 1], j - 1]; 
            
            for (int i = 0; i < q; i++)
            {
                input = Console.ReadLine().Split();
                int u = int.Parse(input[0]);
                int v = int.Parse(input[1]);
                if (depth[u] <= depth[v]) Console.WriteLine(LCA(parents, u, v, depth, dp));
                else Console.WriteLine(LCA(parents, v, u, depth, dp));
            }
        }
        public static void dfs(int v, bool[] visited, int[] depth, int[] parent, Dictionary<int, List<int>> graph)
        {
            visited[v] = true;
            depth[v] = depth[parent[v]] + 1;
            for (int i = 0; i < graph[v].Count; i++)
            {
                if (!visited[graph[v][i]]) dfs(graph[v][i], visited, depth, parent, graph);            
            }
        }
        public static int LCA(int[] parents, int u, int v,  int[] depth, int[,] dp)
        {
            int k = depth[v] - depth[u];
            for (int i = 20; i >= 0; i--)
                if ((k & (1 << i)) > 0)
                    v = dp[v, i];

            if (v == u) return v;
            for (int i = 20; i >= 0; i--)
            {
                if (dp[v,i] != dp[u,i])
                {
                    u = dp[u,i];
                    v = dp[v,i];
                }
            }
            return parents[v];
        }
    }
 }
