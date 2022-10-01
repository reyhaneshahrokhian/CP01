using System;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 1400)
                    Console.WriteLine("Division 4");

                else if (array[i] < 1600)
                    Console.WriteLine("Division 3");

                else if (array[i] < 1900)
                    Console.WriteLine("Division 2");

                else
                    Console.WriteLine("Division 1");
            }
        }
    }
}
