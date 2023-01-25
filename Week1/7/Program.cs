using System;
using System.Collections.Generic;
using System.Linq;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int topic;
            string[] input = Console.ReadLine().Split();
            Dictionary<int, int> values = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                topic = int.Parse(input[i]);
                if (values.ContainsKey(topic))
                    values[topic]++;
                
                else
                    values.Add(topic, 1);
            }
            int max = int.MinValue;
            List<int> counts = new List<int>();
            foreach(var item in values.Values)
            {
                max = Math.Max(max, item);
                counts.Add(item);
            }
            counts.Sort();
            int ans = 1;
            for (int i = 1; i <= max; i++)
            {
                int sum = i, hold = i, temp = counts.Count - 1;
                while(hold % 2 == 0 && temp > 0)
                {
                    hold /= 2;
                    temp--;
                    if (counts[temp] < hold)
                        break;

                    sum += hold;
                }
                ans = Math.Max(ans, sum);
            }
            Console.WriteLine(ans);
        }
    }
}
