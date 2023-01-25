using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int q = int.Parse(input[1]);
            int[] parents = new int[n + 1];
            int[] next = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                parents[i] = i;
                next[i] = i + 1;
            }

            List<string> ans = new List<string>();
            for (int i = 0; i < q; i++)
            {
                input = Console.ReadLine().Split();
                int type = int.Parse(input[0]);
                int u = int.Parse(input[1]);
                int v = int.Parse(input[2]);
                if (type == 1)
                {
                    Union(u, v, parents);
                }
                else if (type == 2)
                {
                    int hold = 0;
                    for (int j = u + 1; j <= v; ) 
                    {
                        Union(j - 1, j, parents);
                        hold = next[j];
                        next[j] = next[v];
                        j = hold;
                    }
                }
                else if (type == 3)
                {
                    int uFind = Find(u, parents);
                    int vFind = Find(v, parents);
                    if (uFind == vFind) ans.Add("YES");
                    else ans.Add("NO");
                }
            }
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
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
}
