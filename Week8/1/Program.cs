using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int q = int.Parse(input[1]);
            input = Console.ReadLine().Split();
            long[] segmentTree = new long[1000000 * 2];
            int[] array = new int[n];
            for (int i = 0; i < n; i++) array[i] = int.Parse(input[i]);
            constructTree(array, 0, n - 1, 0, segmentTree);
            for (int i = 0; i < q; i++)
            {
                input = Console.ReadLine().Split();
                int type = int.Parse(input[0]);
                if(type == 1)
                {
                    int l = int.Parse(input[1]) - 1;
                    int r = int.Parse(input[2]) - 1;
                    Console.WriteLine(getSumUtil(0, n - 1, l, r, 0, segmentTree));
                }
                else if(type == 2)
                {
                    int indx = int.Parse(input[1]) - 1;
                    int newX = int.Parse(input[2]);
                    updateValueUtil(0, n - 1, indx, newX - array[indx], 0, segmentTree);
                    array[indx] = newX;
                }
            }
        }
        public static long constructTree(int[] arr, int start, int end, int indx, long[] segmentTree)
        {
            if (start == end)
            {
                segmentTree[indx] = arr[start];
                return arr[start];
            }
            int mid = start + (end - start) / 2;
            segmentTree[indx] = constructTree(arr, start, mid, indx * 2 + 1, segmentTree) + constructTree(arr, mid + 1, end, indx * 2 + 2, segmentTree);
            return segmentTree[indx];
        }
        public static long getSumUtil(int start, int end, int source, int sink, int indx, long[] segmentTree)
        {
            if (source <= start && sink >= end) return segmentTree[indx];
            if (end < source || start > sink) return 0;
            int mid = start + (end - start) / 2;
            return getSumUtil(start, mid, source, sink, 2 * indx + 1, segmentTree) + getSumUtil(mid + 1, end, source, sink, 2 * indx + 2, segmentTree);
        }
        public static void updateValueUtil(int start, int end, int indx, int diff, int current, long[] segmentTree)
        {
            if (indx < start || indx > end) return;

            segmentTree[current] += (long)diff;
            if (end != start)
            {
                int mid = start + (end - start) / 2;
                updateValueUtil(start, mid, indx, diff, 2 * current + 1, segmentTree);
                updateValueUtil(mid + 1, end, indx, diff, 2 * current + 2, segmentTree);
            }
        }
    }
}
