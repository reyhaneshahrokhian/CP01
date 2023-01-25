using System;
using System.Collections.Generic;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, List<Tuple<int, int>>> graph = new Dictionary<int, List<Tuple<int, int>>>();
            for (int i = 0; i <= n; i++)
            {
                graph.Add(i, new List<Tuple<int, int>>());
            }
            long sum = 0;
            for (int i = 0; i < n - 1; i++)
            {
                string[] input = Console.ReadLine().Split();
                graph[int.Parse(input[0])].Add(new Tuple<int, int>(int.Parse(input[1]), int.Parse(input[2])));
                graph[int.Parse(input[1])].Add(new Tuple<int, int>(int.Parse(input[0]), int.Parse(input[2])));
                sum += int.Parse(input[2]);
            }
            bool[] visited = new bool[n + 1];
            int[] distance = new int[n + 1];
            DFS(graph, visited, 1, 0, distance);
            int hold = -1;
            for (int i = 1; i <= n; i++)
            {
                hold = Math.Max(hold, distance[i]);
            }
            Console.WriteLine(sum * 2 - hold);
        }
        public static void DFS(Dictionary<int, List<Tuple<int, int>>> graph, bool[] visited, int node, int ans, int[] distance)
        {
            visited[node] = true;
            distance[node] = ans;
            for (int i = 0; i < graph[node].Count; i++)
            {
                if (!visited[graph[node][i].Item1])
                {
                    DFS(graph, visited, graph[node][i].Item1, ans + graph[node][i].Item2, distance);
                    visited[graph[node][i].Item1] = false;
                }
            }
            visited[node] = false;
        }
    }
}
