using System;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                max = Math.Max(max, array[i]);
            }
            long[] segmentTree = new long[2 * 1000000];
            long answer = 0;
            for (int i = 0; i < n; i++)
            {
                answer += count(segmentTree, 0, 0, n, array[i] + 1, n);
                answer %= 100000;
                update(segmentTree, 0, 0, n, array[i]);
            }
            Console.WriteLine(answer);
        }
        static void update(long[] segmentTree, int index, int start, int end, int number)
        {
            if (number < start || number > end) return;
            segmentTree[index] += 1;
            if(start != end)
            {
                int mid = start + (end - start) / 2;
                update(segmentTree, 2 * index + 1, start, mid, number);
                update(segmentTree, 2 * index + 2, mid + 1, end, number);
            }
        }
        static long count(long[] segmentTree, int index, int start, int end, int s, int e)
        {
            if (s <= start && end <= e) return segmentTree[index];
            if (start > e || end < s) return 0;
            
            int mid = start + (end -start)/ 2;
            return count(segmentTree, 2 * index + 1, start, mid, s, e) + count(segmentTree, 2 * index + 2, mid + 1, end, s, e);
        }
    }
}
