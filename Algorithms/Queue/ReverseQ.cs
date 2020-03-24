using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void ReverseQ()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(100);
            q.Enqueue(1000);
            int[] data = new int[q.Count];
            q.CopyTo(data, 0);
            for (var x = data.Length - 1; x >= 0; x--)
            {
                Debug.WriteLine(data[x]);
            }
        }
    }
}