using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[,] A = new int[n, n];
            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split();
                int x = int.Parse(input[0]);
                int y = int.Parse(input[1]);
                A[x - 1 , y - 1] = 1;
                A[y - 1, x - 1] = 1;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
