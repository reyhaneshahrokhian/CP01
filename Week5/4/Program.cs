using System;
using System.Collections.Generic;

namespace _4
{
    class Program
    {
        public static long mod = (long)Math.Pow(10, 9) + 7;
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
            for (int i = 1; i <= n; i++)
            {
                graph.Add(i, new List<int>());
            }
            for (int i = 0; i < n - 1; i++)
            {
                input = Console.ReadLine().Split();
                if(int.Parse(input[2]) == 0)
                {
                    graph[int.Parse(input[0])].Add(int.Parse(input[1]));
                    graph[int.Parse(input[1])].Add(int.Parse(input[0]));
                }
            }
            bool[] visited = new bool[n + 1];
            List<int> gg = DFS(graph, visited, n);
            long hold = 0;
            for (int i = 0; i < gg.Count; i++)
            {
                hold += pow(gg[i], k);
                hold %= mod;
            }
            Console.WriteLine((pow(n, k) - hold + mod) % mod);
        }
        public static long pow(int n , int k)
        {
            long ans = 1;
            for (int i = 0; i < k; i++)
            {
                ans *= n;
                ans %= mod;
            }
            return ans;
        }
        public static List<int> DFS(Dictionary<int, List<int>> graph, bool[] visited, int n)
        {
            List<int> ans = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (visited[i]) continue;

                visited[i] = true;
                int count = 0;
                Stack<int> stack = new Stack<int>();
                stack.Push(i);

                while (stack.Count > 0)
                {
                    int hold = stack.Pop();
                    visited[hold] = true;
                    count++;                
                    if (graph.ContainsKey(hold))
                    {
                        foreach (var item in graph[hold])
                        {
                            if (!visited[item])
                                stack.Push(item);
                        }
                    }
                }
                ans.Add(count);                
            }
            return ans;
        }
    }
}
