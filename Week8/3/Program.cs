using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int[] array = new int[n];
			Dictionary<int, int> dic = new Dictionary<int, int>();
			int[] primary = new int[1000000];
			int[] hold = new int[1000000];
			for (int i = 0; i < n; i++)
			{
				array[i] = int.Parse(input[i]);
				if (dic.ContainsKey(array[i])) primary[i] = dic[array[i]]++;
                else dic.Add(array[i], 1);              
			}
			long ans = 0;
			for (int i = n - 1; i >= 0; i--)
			{
				for (int j = primary[i]; j != 0; j -= (j & -j))
					ans += hold[j];
				for (int j = dic[array[i]] - primary[i]; j < n; j += (j & -j))
					hold[j]++;
			}
			Console.WriteLine(ans);
		}
    }
}
