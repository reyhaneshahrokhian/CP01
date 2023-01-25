using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int q = int.Parse(input[1]);
            input = Console.ReadLine().Split();
            long[] array = new long[n];
            for (int i = 0; i < n; i++) array[i] = long.Parse(input[i]);
            long[] blocks = new long[(int)Math.Sqrt(n) + 1];
            for (int i = 0; i < array.Length; i++) blocks[i / blocks.Length] += array[i];
            for (int i = 0; i < q; i++)
            {
                input = Console.ReadLine().Split();
                int type = int.Parse(input[0]);
                if (type == 1)
                {
                    int l = int.Parse(input[1]) - 1;
                    int r = int.Parse(input[2]) - 1;
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
                else if (type == 2)
                {
                    int indx = int.Parse(input[1]) - 1;
                    long newX = long.Parse(input[2]);
                    blocks[indx / blocks.Length] += (newX - array[indx]);
                    array[indx] = newX;
                }
            }
        }
    }
}
