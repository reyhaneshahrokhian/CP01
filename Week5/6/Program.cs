using System;
using System.Collections.Generic;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
            for (int i = 0; i <= n; i++)
            {
                graph.Add(i, new List<int>());
            }
            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split();
                graph[int.Parse(input[0])].Add(int.Parse(input[1]));
                graph[int.Parse(input[1])].Add(int.Parse(input[0]));
            }
            bool[] visited = new bool[n + 1];

            for (int i = 1; i <= n; i++)
            {
                if(graph[i].Count > 0)
                {
                    DFS(visited, graph, i);
                    break;
                }
            }
            
            bool flag = true;
            for (int i = 1; i <= n; i++)
            {
                if (!visited[i] && graph[i].Count > 0)
                {
                    flag = false;
                    break;
                }
            }
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (graph[i].Count % 2 == 1)
                    count++;                   
            }
            if(!flag)
                Console.WriteLine("NO");
            else if (count == 0 || count == 2)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        public static void DFS(bool[] visited, Dictionary<int, List<int>> graph, int node)
        {
            visited[node] = true;

            for (int i = 0; i < graph[node].Count; i++)
            {
                if (!visited[graph[node][i]])
                    DFS(visited, graph, graph[node][i]);
                
            }
        }
    }
}
