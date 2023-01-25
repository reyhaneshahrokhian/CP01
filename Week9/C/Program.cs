using System;
using System.Collections.Generic;

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
                int n = int.Parse(input[0]);
                int m = int.Parse(input[1]);
                input = Console.ReadLine().Split();
                int[] array = new int[n];
                for (int j = 0; j < n; j++) array[j] = int.Parse(input[j]);
                Array.Sort(array);
                int[] count = new int[1000000];
                for (int j = 0; j < m; j++) count[j] = 0;
                int ans = 0;
                int answerrr = 1000000;
                int point2 = 0;
                for (int point1 = 0; point1 < n; point1++)
                {
                    func1(array[point1], count, ans);
                    if (ans == m) answerrr = Math.Min(answerrr, array[point1] - array[point2]);
                    while(point2 < point1)
                    {
                        func2(array[point2], count, ans);
                        if(ans < m)
                        {
                            func1(array[point2], count, ans);
                            break;
                        }
                        point2++;
                    }
                }
                if (answerrr != 1000000) Console.WriteLine(answerrr);
                else Console.WriteLine(-1);
            }
        }
        public static void func1(int xx, int[] count, int ans)
        {
            for (int i = 1; i * i <= xx; i++)
            {
                if(xx % i == 0)
                {
                    if (count[i] == 0) ans++;
                    if (count[xx / i] == 0) ans++;
                    count[i]++;
                    count[xx / i]++;
                }
            }
        }
        public static void func2(int xx, int[] count, int ans)
        {
            for (int i = 1; i * i <= xx; i++)
            {
                if (xx % i == 0)
                {
                    count[i]--;
                    count[xx / i]--;
                    if (count[i] == 0) ans--;
                    if (count[xx / i] == 0) ans--;
                }
            }
        }
    }
}
