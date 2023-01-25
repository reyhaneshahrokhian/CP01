using System;

namespace _4
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
            long[] segmentTree = new long[1000000 * 8];
            for (int i = 0; i < n; i++) array[i] = int.Parse(input[i]);
            constructTree(array, 0, n, 1, segmentTree);
            for (int i = 0; i < q; i++)
            {
                input = Console.ReadLine().Split();
                int l = int.Parse(input[0]) - 1;
                int r = int.Parse(input[1]);
                int x = int.Parse(input[2]);
                Console.WriteLine(getMax(0, n, l, r, 1, segmentTree, x));
            }
        }
        public static void constructTree(int[] arr, int start, int end, int indx, long[] segmentTree)
        {
            if (end - start == 1)
            {
                segmentTree[indx] = arr[start];
                return;
            }
            int mid = (end + start) / 2;
            constructTree(arr, start, mid, indx * 2, segmentTree);
            constructTree(arr, mid, end, indx * 2 + 1, segmentTree);
            segmentTree[indx] = Math.Max(segmentTree[indx * 2 + 1], segmentTree[indx * 2]);
        }
        public static long getMax(int start, int end, int source, int sink, int indx, long[] segmentTree, int x)
        {
            if (end <= source || start >= sink || segmentTree[indx] < x) return -1;
            if (end - start == 1) return start + 1;
            int mid = (end + start) / 2;
            long hold = getMax(start, mid, source, sink, 2 * indx, segmentTree, x);
            if (hold != -1) return hold;
            return getMax(mid, end, source, sink, 2 * indx + 1, segmentTree, x);
        }
    }
}
