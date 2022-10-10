using System;
using System.Collections.Generic;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<int> answer = new List<int>();
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int[] A = new int[n];
                int[] B = new int[n];
                int countA = 0, countB = 0;
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    A[j] = int.Parse(input[j]);
                    if (A[j] == 1)
                        countA++;
                }
                input = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    B[j] = int.Parse(input[j]);
                    if (B[j] == 1)
                        countB++;
                }
                int ans = 0;
                int points = 0;
                for (int j = 0; j < n; j++)
                {
                    if (A[j] != B[j])
                        points++;                                            
                }
                ans = Math.Min(points, Math.Abs(countB - countA) + 1);
                answer.Add(ans);
            }
            foreach (var item in answer)
            {
                Console.WriteLine(item);
            }
        }
    }
}
