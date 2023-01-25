using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int q = int.Parse(input[1]);
            input = Console.ReadLine().Split();
            int[] array = new int[n];
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(input[i]);
                if (dic.ContainsKey(array[i])) dic[array[i]].Add(i);
                else dic.Add(array[i], new List<int>() { i });
            }
            for (int i = 0; i < q; i++)
            {
                input = Console.ReadLine().Split();
                int l = int.Parse(input[0]) - 1;
                int r = int.Parse(input[1]) - 1;
                int x = int.Parse(input[2]);
                long indx1 = Array.BinarySearch(dic[x].ToArray(), l);
                long indx2 = Array.BinarySearch(dic[x].ToArray(), r);
                // Console.WriteLine(indx1 + " " + indx2);
                if (indx2 == -1) Console.WriteLine("0");
                else if (indx1 < 0 && indx2 < 0) Console.WriteLine(indx1 - indx2);
                else if (indx1 < 0) Console.WriteLine(indx2 - ((indx1 + 2) * -1));
                else if (indx2 < 0) Console.WriteLine((indx2 + 1) * -1 - indx1);
                else Console.WriteLine(indx2 - indx1 + 1);
                /*if (dic[x][0] > r) Console.WriteLine(0);
                else Console.WriteLine(binarySearch(dic[x].ToArray(), r) - binarySearch(dic[x].ToArray(), l) + 1);*/
            }
        }
        static public int binarySearch(int[] v, int To_Find)
        {
            int lo = 0;
            int hi = v.Length - 1;
            int mid;
            while (hi - lo > 1)
            {
                mid = (hi + lo) / 2;
                if (v[mid] < To_Find) lo = mid + 1;                
                else hi = mid;              
            }
            if (v[hi] == To_Find) return hi;
            else return lo;
        }
    }
}
