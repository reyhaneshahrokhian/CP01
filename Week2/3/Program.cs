using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(input[i]);
            }
            int[] dp = new int[n];
            dp[0]= array[0];
            int count = 1;
            for (int i = 1; i < n; i++)
            {
                if (array[i] > dp[count - 1])
                {
                    dp[count] = array[i];
                    count++;
                }
                else
                {
                    int l = -1, r = count - 1;
                    while (r - l > 1)
                    {
                        int middle = l + (r - l) / 2;
                        if (array[i] > dp[middle])
                            l = middle;
                        else
                            r = middle;
                    }

                    dp[r] = array[i];
                }
            }
            Console.WriteLine(count);
        }
    }
}
