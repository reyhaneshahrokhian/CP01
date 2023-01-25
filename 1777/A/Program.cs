using System;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                string[] input = Console.ReadLine().Split();
                int[] array = new int[n];
                for (int j = 0; j < n; j++) array[j] = int.Parse(input[j]);
                long ans = 0;
                for (int j = 1; j < n; j++)
                {
                    if (array[j] % 2 == array[j - 1] % 2) ans++;
                }
                Console.WriteLine(ans);
            }
        }
    }
}
