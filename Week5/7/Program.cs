using System;
using System.Collections.Generic;

namespace _7
{
    class Program
    {
        public static Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        public static int[] colors;
        public static int RCount = 0;
        public static int BCount = 0;
        public static int[,] dp;
        public static bool[] visited;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            colors = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                graph.Add(i, new List<int>());
            }
            for (int i = 0; i < n; i++)
            {
                colors[i + 1] = int.Parse(input[i]);
                if (colors[i + 1] == 1) RCount++;
                else if (colors[i + 1] == 2) BCount++;
            }
            for (int i = 0; i < n - 1; i++)
            {
                input = Console.ReadLine().Split();
                graph[int.Parse(input[0])].Add(int.Parse(input[1]));
                graph[int.Parse(input[1])].Add(int.Parse(input[0]));
            }
            visited = new bool[n + 1];
            dp = new int[n + 1, 4];
            DFS(1);
            int ans = 0;
            for (int i = 1; i <= n; i++)
            {
                if ((dp[i, 1] == RCount && dp[i, 2] == 0) || (dp[i, 2] == BCount && dp[i, 1] == 0))
                    ans++;
            }
            Console.WriteLine(ans);
        }
        public static void DFS(int node)
        {
            visited[node] = true;
            dp[node, colors[node]]++;
            for (int i = 0; i < graph[node].Count; i++)
            {
                if (!visited[graph[node][i]])
                {
                    DFS(graph[node][i]);
                    dp[node, 1] += dp[graph[node][i], 1];
                    dp[node, 2] += dp[graph[node][i], 2];
                }
            }
        }
    }
}
