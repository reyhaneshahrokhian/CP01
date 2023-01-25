using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long m = long.Parse(input[1]);
            Dictionary<Tuple<int, int>, int> G = new Dictionary<Tuple<int, int>, int>();
            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split();
                G.Add(new Tuple<int, int>(int.Parse(input[0]) - 1, int.Parse(input[1]) - 1 ), 1);
                G.Add(new Tuple<int, int>(int.Parse(input[1]) - 1, int.Parse(input[0]) - 1), 1);
            }
            long q = long.Parse(Console.ReadLine());
            List<string> ans = new List<string>();
            for (int i = 0; i < q; i++)
            {
                input = Console.ReadLine().Split();
                if (G.ContainsKey(new Tuple<int, int>(int.Parse(input[0])- 1, int.Parse(input[1]) - 1)))
                {
                    ans.Add("NO");
                }
                else
                    ans.Add("YES");
            }
            for (int i = 0; i < q; i++)
            {
                Console.WriteLine(ans[i]);
            }
        }
    }
}
