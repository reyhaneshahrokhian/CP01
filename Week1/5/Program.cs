using System;
using System.Collections.Generic;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] places = new string[n];
            for (int i = 0; i < n; i++)
            {
                places[i] = Console.ReadLine();
            }
            int q = int.Parse(Console.ReadLine());
            string[] emails = new string[q];
            for (int i = 0; i < q; i++)
            {
                emails[i] = Console.ReadLine();
            }
            int count = 0;
            int check = 0;
            List<string> hold = new List<string>();
            for (int i = 0; i < q; i++)
            {
                if (!hold.Contains(emails[i]) && check != n - 1)
                {
                    hold.Add(emails[i]);
                    check++;
                }
                else if(!hold.Contains(emails[i]) && check == n - 1)
                {
                    count++;
                    hold.RemoveRange(0, hold.Count);
                    hold.Add(emails[i]);
                    check = 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
