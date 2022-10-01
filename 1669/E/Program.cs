using System;
using System.Collections.Generic;

namespace E
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int n;
            string input;
            List<long> ans = new List<long>();
            for (int i = 0; i < t; i++)
            {
                n = int.Parse(Console.ReadLine());
                int[][] array = new int[11][];
                for (int j = 0; j < 11; j++)
                {
                    array[j] = new int[11];
                }
                long answer = 0;
                for (int j = 0; j < n; j++)
                {
                    input = Console.ReadLine();

                    for (int k = 0; k < 11; k++)
                    {
                        if ((int)input[0] != k + 97)
                        {
                            answer += array[k][(int)input[1] - 97];
                        }
                        if ((int)input[1] != k + 97)
                        {
                            answer += array[(int)input[0] - 97][k];
                        }
                    }
                    array[(int)input[0] - 97][(int)input[1] - 97]++;
                }
                ans.Add(answer);
            }
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
