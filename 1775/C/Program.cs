using System;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split();
                long nn = long.Parse(input[0]);
                long xx = long.Parse(input[1]);
                if ((nn & xx) == xx)
                {
                    string n = Convert.ToString(Convert.ToInt64(input[0], 10), 2);
                    string x = Convert.ToString(Convert.ToInt64(input[1], 10), 2);
                    if(n.Length > x.Length)
                    {
                        string ans = "1";
                        for (int j = 0; j < n.Length; j++)
                        {
                            ans += "0";
                        }
                        long hold = Convert.ToInt64(ans, 2);
                        if ((hold & nn) == xx) Console.WriteLine(Convert.ToString(Convert.ToInt64(ans, 2), 10));
                        else Console.WriteLine("-1");
                        
                    }
                    else
                    {
                        string ans = ((nn ^ xx) + nn).ToString();
                        if ((long.Parse(ans) & nn) == xx) Console.WriteLine(ans);
                        else Console.WriteLine("-1");
                    }
                }
                else Console.WriteLine("-1");
            }
        }
    }
}
