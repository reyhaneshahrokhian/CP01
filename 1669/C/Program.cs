using System;
using System.Collections.Generic;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int n;
            string[] input;
            List<string> ans = new List<string>();
            for (int i = 0; i < t; i++)
            {
                n = int.Parse(Console.ReadLine());
                input = Console.ReadLine().Split();

                bool flag = true;
                for (int j = 2; j < n; j += 2)
                {
                    if (int.Parse(input[j]) % 2 != int.Parse(input[j - 2]) % 2)
                    {
                        flag = false;
                        break;
                    }
                }
                for (int j = 3; j < n; j += 2)
                {
                    if (int.Parse(input[j]) % 2 != int.Parse(input[j - 2]) % 2)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                    ans.Add("YES");
                else
                    ans.Add("NO");
            }
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
