using System;
using System.Collections.Generic;
using System.Linq;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long k = long.Parse(input[1]);
            List<Tuple<long, long>> fruits = new List<Tuple<long, long>>();
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                long a = long.Parse(input[0]);
                long b = long.Parse(input[1]);
                fruits.Add(new Tuple<long, long> (a, b));
            }
            fruits = fruits.OrderBy(x => x.Item1).ToList();
            for (int i = 0; i < n; i++)
            {
                if(k >= fruits[i].Item1 && fruits[i].Item2 > fruits[i].Item1)
                {
                    k += (fruits[i].Item2 - fruits[i].Item1);
                }
                else if (k < fruits[i].Item1)
                {
                    break;
                }
            }
            Console.WriteLine(k);
        }
    }
}
