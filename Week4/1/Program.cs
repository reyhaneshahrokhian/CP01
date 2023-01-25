using System;
using System.Collections.Generic;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<List<Tuple<int, int>>> adj = new List<List<Tuple<int, int>>>();
            for (int i = 0; i <= n; i++)
            {
                adj.Add(new List<Tuple<int, int>>());
            }
            for (int i = 0; i < n - 1; i++)
            {
                string[] input = Console.ReadLine().Split();
                adj[int.Parse(input[0])].Add(new Tuple<int, int>(int.Parse(input[1]), 0));
                adj[int.Parse(input[1])].Add(new Tuple<int, int>(int.Parse(input[0]), 1));
            }
            List<bool> visited = new List<bool>();
            for (int i = 0; i <= n; i++)
            {
                visited.Add(false);
            }
            int firstDfs = DFS(1, visited, adj);
            for (int i = 0; i <= n; i++)
            {
                visited[i] =false;
            }
            int[] ans = DfsAns(1, visited, adj, n, firstDfs);
            int min = int.MaxValue;
            foreach (var item in ans)
            {
                min = Math.Min(min, item);
            }
            Console.WriteLine(min);
            for (int i = 0; i < n; i++)
            {
                if (ans[i] == min)
                    Console.Write(i + 1 + " ");
            }
        }
        public static int[] DfsAns(int v, List<bool> visited, List<List<Tuple<int, int>>> adj, int n, int cost)
        {
            int[] dp = new int[n];
            dp[0] = cost;
            //List<int> dp = new List<int>();
            //dp.Add(cost);
            Stack<int> stack = new Stack<int>();
            stack.Push(v);

            while (stack.Count != 0)
            {
                v = stack.Pop();
                visited[v] = true;
                for (int i = 0; i < adj[v].Count; i++)
                {
                    int x = adj[v][i].Item1;
                    if (!visited[x])
                    {
                        stack.Push(x);
                        if (adj[v][i].Item2 == 1)
                            dp[x - 1] = dp[v - 1] - 1;
                        else
                            dp[x - 1] = dp[v - 1] + 1;
                    }
                }
            }
            return dp;
        }
        public static int DFS(int v, List<bool> visited, List<List<Tuple<int, int>>> adj)
        {
            int cost = 0;
            Stack<int> stack = new Stack<int>();
            stack.Push(v);

            while (stack.Count != 0)
            {
                v = stack.Pop();
                visited[v] = true;
                for (int i = 0; i < adj[v].Count; i++)
                {
                    int x = adj[v][i].Item1;
                    if (!visited[x])
                    {
                        stack.Push(x);
                        if (adj[v][i].Item2 == 1)
                            cost++;
                    }
                }
            }
            return cost;
        }
    }
}
