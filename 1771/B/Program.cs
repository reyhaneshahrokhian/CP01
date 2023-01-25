using System;
using System.Collections.Generic;
using System.Linq;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<long> ans = new List<long>();
            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split();
                int n = int.Parse(input[0]);
                int m = int.Parse(input[1]);
                long answer = 0;
                List<Tuple<int, int>> friends = new List<Tuple<int, int>>();
                for (int j = 0; j < m; j++)
                {
                    input = Console.ReadLine().Split();
                    if(int.Parse(input[0]) < int.Parse(input[1]))
                        friends.Add(new Tuple<int, int>(int.Parse(input[0]), int.Parse(input[1])));
                    else
                        friends.Add(new Tuple<int, int>(int.Parse(input[1]), int.Parse(input[0])));
                }
                friends = friends.OrderBy(x => x.Item1).ToList();
                int[] mins = new int[m + 1];
                mins[m] = n + 1;
                for (int j = m - 1; j >= 0; j--)
                {
                    mins[j] = Math.Min(mins[j + 1], friends[j].Item2);
                }
                int index = 0;
                for (int j = 1; j <= n; j++)
                {
                    while(index < m && friends[index].Item1 < j)
                    {
                        index++;
                    }
                    answer += (mins[index] - j);
                }
                ans.Add(answer);
            }
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
