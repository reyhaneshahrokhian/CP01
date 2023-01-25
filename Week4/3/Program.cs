using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            int k = int.Parse(input[1]);
            long ans = 1;
            for (int i = 2; i <= k; i++)
            {
                if(i == 2)
                {
                    long temp = (n * (n - 1)) / 2;
                    ans += temp;
                }
                else if(i == 3)
                {
                    long temp = ((n * (n - 1) * (n - 2)) / 6) * 2;
                    ans += temp;
                }
                else if (i == 4)
                {
                    long temp = ((n * (n - 1) * (n - 2) * (n - 3)) / 24) * 9;
                    ans += temp;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
