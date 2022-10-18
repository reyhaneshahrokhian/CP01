using System;
using System.Collections.Generic;
using System.Linq;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<int> ans = new List<int>();
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                string ZeroOne = Console.ReadLine();
                int[] lids = new int[n];
                for (int j = 0; j < n; j++)
                {
                    lids[j] = int.Parse(ZeroOne[j].ToString());
                }
                string[] input = Console.ReadLine().Split();
                int[] array = new int[n];
                for (int j = 0; j < n; j++)
                {
                    array[j] = int.Parse(input[j]);
                }
                int answer = 0;
                for (int j = 0; j < n - 1; j++)
                {
                    int indx = j;
                    if(lids[j] == 0)
                    {
                        int min = array[j];
                        int hold = j;
                        if(lids[j + 1] == 1)
                        {
                            j++;
                            while (lids[j] == 1 && j < n)
                            {
                                if (array[j] < min)
                                {
                                    hold = j;
                                    min = array[j];
                                }
                                j++;
                                if (j == n)
                                    break;
                            }
                            j--;
                        }
                        if(min < array[indx])
                        {
                            lids[indx] = 1;
                            lids[hold] = 0;
                        }
                    }
                }
                for (int j = 0; j < n; j++)
                {
                    if (lids[j] == 1)
                        answer += array[j];
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
