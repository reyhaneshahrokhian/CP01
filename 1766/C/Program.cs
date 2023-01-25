using System;
using System.Collections.Generic;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<string> ans = new List<string>();
            for (int i = 0; i < t; i++)
            {
                int m = int.Parse(Console.ReadLine());
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                bool flag = true;
                if (first[0] == 'B')
                {
                    int last = 0;
                    int count = 1;
                    int j = 0;
                    int k = 0;
                    while (true)
                    {
                        if (k == m - 1) break;
                        if (last == 0 && count < 2 && second[k] == 'B')
                        {
                            last = 1;
                            count = 2;
                            j++;
                        }
                        else if (last == 0 && first[k + 1] == 'B')
                        {
                            k++;
                            count = 1;
                        }
                        else if (last == 1 && count < 2 && first[k] == 'B')
                        {
                            last = 0;
                            count = 2;
                            j--;
                        }
                        else if (last == 1 && second[k + 1] == 'B')
                        {
                            k++;
                            count = 1;
                        }
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                if ((second[0] == 'B' && first[0] != 'B') || (second[0] == 'B' && first[0] == 'B' && !flag))
                {
                    int last = 1;
                    int count = 1;
                    int j = 1;
                    int k = 0;
                    while (true)
                    {
                        if (k == m - 1) break;
                        if (last == 0 && count < 2 && second[k] == 'B')
                        {
                            last = 1;
                            count = 2;
                            j++;
                        }
                        else if (last == 0 && first[k + 1] == 'B')
                        {
                            k++;
                            count = 1;
                        }
                        else if (last == 1 && count < 2 && first[k] == 'B')
                        {
                            last = 0;
                            count = 2;
                            j--; ;
                        }
                        else if (last == 1 && second[k + 1] == 'B')
                        {
                            k++;
                            count = 1;
                        }
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                if (flag) ans.Add("YES");
                else ans.Add("NO");
            }
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
