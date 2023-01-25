using System;
using System.Collections.Generic;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<string> ans = new List<string>();
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                string input = Console.ReadLine();
                Dictionary<string, int> dic = new Dictionary<string, int>();
                bool flag = false;
                for (int j = 0; j < n - 1; j++)
                {
                    if (dic.ContainsKey(input.Substring(j, 2)))
                    {
                        if (dic[input.Substring(j, 2)] != (j - 1))
                        {
                            ans.Add("YES");
                            flag = true;
                            break;
                        }
                    }
                    else
                        dic.Add(input.Substring(j, 2), j);
                }
                if (!flag) ans.Add("NO");
            }
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
