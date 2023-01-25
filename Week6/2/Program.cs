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
            int k = int.Parse(input[2]);
            List<Edge> edges = new List<Edge>();
            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split();
                Edge edge = new Edge(int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2]));
                edges.Add(edge);
            }
            int[] parents = new int[n + 1];
            for (int i = 1; i <= n; i++) parents[i] = i;

            long sum =0;
            List<int> weight = new List<int>();
            edges = edges.OrderBy(x => x.weight).ThenBy(x => x.u).ThenBy(x => x.v).ToList();
            for (int i = 0; i < edges.Count; i++)
            {
                if (DisjointSet.Find(edges[i].u, parents) != DisjointSet.Find(edges[i].v, parents))
                {
                    DisjointSet.Union(edges[i].u, edges[i].v, parents);
                    sum += edges[i].weight;
                    weight.Add(edges[i].weight);
                }
            }
           // weight = weight.OrderByDescending(x => x).ToList();
            weight.Sort();
            bool  flag = true;
            int gp = DisjointSet.Find(1, parents);
            for (int i = 2; i <= n; i++)
            {
                if (DisjointSet.Find(i, parents) != gp)
                {
                    flag = false;
                    Console.WriteLine(-1);
                    break;
                }
            }
            if (flag)
            {
                if (weight.Count > k) Console.WriteLine(-1);
                else if (sum <= k) Console.WriteLine(0);
                else
                {
                    int count = 0;
                    for (int i = weight.Count - 1; i >= 0; i--)
                    {
                        count++;
                        sum -= (weight[i] - 1);
                        if (sum <= k)
                        {
                            Console.WriteLine(count);
                            break;
                        }
                    }
                    /*for (int i = 0; i < weight.Count; i++)
                    {
                        sum -= (weight[i] - 1);
                        if (sum <= k)
                        {
                            Console.WriteLine(i + 1);
                            break;
                        }
                    }*/
                }
            }
        }
    }
    public class DisjointSet
    {
        public static int Find(int i, int[] parents)
        {
            if (i != parents[i]) parents[i] = Find(parents[i], parents);
            return parents[i];
        }

        public static void Union(int u, int v, int[] parents)
        {
            int uFind = Find(u, parents);
            int vFind = Find(v, parents);
            if (uFind != vFind) parents[vFind] = uFind;

        }
    }
    public class Edge
    {
        public int u;
        public int v;
        public int weight;
        public Edge(int u, int v, int weight)
        {
            this.u = u;
            this.v = v;
            this.weight = weight;
        }
    }
}
