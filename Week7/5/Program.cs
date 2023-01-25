using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int q = int.Parse(input[1]);
            input = Console.ReadLine().Split();
            int[] array = new int[n];
            for (int i = 0; i < n; i++) array[i] = int.Parse(input[i]);
            long[] dp = new long[n];
            long[] hold = new long[n];
            for (int i = n - 1; i >= 0; i--) cal(i, dp, hold, array);
            for (int i = 0; i < q; i++)
            {
                input = Console.ReadLine().Split();
                int type = int.Parse(input[0]);
                if (type == 0)
                {
                    int a = int.Parse(input[1]) - 1;
                    int b = int.Parse(input[2]);
                    array[a] = b;
                    for (int j = a; j >= 0 && j / 450 == a / 450; j--) cal(j, dp, hold, array);
                }
                else if (type == 1)
                {
                    int a = int.Parse(input[1]) - 1;
                    int dwn = 0, s = 0;
                    for (; a < n; dwn = (int)hold[a], a = dwn + array[(int)dwn]) s += (int)dp[a] + 1;
                    Console.WriteLine(dwn + 1 + " "+ s);
                }
            }
        }
        public static void cal(int indx, long[] dp, long[] hold, int[] array)
        {
            if (indx + array[indx] >= array.Length || indx / 450 != (indx + array[indx]) / 450)
            {
                hold[indx] = indx;
                dp[indx] = 0;
            }
            else
            {
                hold[indx] = hold[indx + array[indx]];
                dp[indx] = dp[indx + array[indx]] + 1;
            }
        }
    }
}
