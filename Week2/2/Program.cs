using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] dp = new int[input.Length];
            int hold = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsUpper(input[i]))
                {
                    hold++;
                }
            }
            int ans = hold;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsUpper(input[i]))
                {
                    hold--;
                    ans = Math.Min(ans, hold);
                }
                else
                {
                    hold++;
                    ans = Math.Min(ans, hold);
                }
            }
            Console.WriteLine(ans);
        }
    }
}
