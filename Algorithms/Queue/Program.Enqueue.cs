using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void Enqueue()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(1); //first in first out
            q.Enqueue(10);
            q.Enqueue(100);
            foreach (var item in q)
            {
                Debug.WriteLine(item);
            }
        }
    }
}