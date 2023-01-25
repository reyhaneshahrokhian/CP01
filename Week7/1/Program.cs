using System;

namespace _1
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
            int[] blocks = new int[(int)Math.Sqrt(n) + 1];
            for (int i = 0; i < array.Length; i++) blocks[i / blocks.Length] += array[i];
            for (int i = 0; i < q; i++)
            {
                input = Console.ReadLine().Split();
                int l = int.Parse(input[0]) - 1;
                int r = int.Parse(input[1]) - 1;
                long sum = 0;
                for (int j = l; j <= r;)
                {
                    if (j % blocks.Length == 0 && j + blocks.Length - 1 <= r)
                    {
                        sum += blocks[j / blocks.Length];
                        j += blocks.Length;
                    }
                    else
                    {
                        sum += array[j];
                        j++;
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}
