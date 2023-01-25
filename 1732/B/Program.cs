using System;
using System.Collections.Generic;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<int> ans = new List<int>();
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                string input = Console.ReadLine();
                int hold = 0;
                for (int j = 1; j < n; j++)
                {
                    if(input[j] != input[j - 1])
                    {
                        hold++;
                    }
                }
                if (input[0] == '0')
                    hold--;
                if (hold < 0)
                    hold = 0;
                ans.Add(hold);
            }
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
