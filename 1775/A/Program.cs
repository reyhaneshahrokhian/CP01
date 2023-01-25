using System;
using System.Collections.Generic;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string a, b, c;
                bool flag = false;
                for (int j = 1; j < input.Length - 2; j++)
                {
                    if(input[j] == 'a')
                    {
                        b = "a";
                        a = input.Substring(0, j);
                        c = input.Substring(j + 1);
                        Console.WriteLine(a + " " + b + " " + c);
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    a = input[0].ToString();
                    c = input[input.Length - 1].ToString();
                    b = input.Substring(1, input.Length - 2);
                    Console.WriteLine(a + " " + b + " " + c);
                }
            }
        }
    }
}
