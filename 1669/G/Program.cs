using System;
using System.Collections.Generic;

namespace G
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<char[,]> ans = new List<char[,]>();
            List<int> rows = new List<int>();
            List<int> columns = new List<int>();
            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split();
                int n = int.Parse(input[0]);
                int m = int.Parse(input[1]);
                char[,] grid = new char[n, m];
                for (int j = 0; j < n; j++)
                {
                    string row = Console.ReadLine();
                    for (int k = 0; k < m; k++)
                    {
                        grid[j, k] = row[k];
                    }
                }

                for (int j = n - 1; j >= 0; j--)
                {
                    for (int k = 0; k < m; k++)
                    {
                        if(grid[j, k] == '*')
                        {
                            int newR = j;
                            while (newR < n - 1 && grid[newR + 1, k] == '.') {
                                newR++;
                            }
                            grid[j, k] = '.';
                            grid[newR, k] = '*';
                        }
                    }
                }
                ans.Add(grid);
                rows.Add(n);
                columns.Add(m);
            }
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < rows[i]; j++)
                {
                    for (int k = 0; k < columns[i]; k++)
                    {
                        Console.Write(ans[i][j,k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
