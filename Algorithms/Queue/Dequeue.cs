using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void Dequeue()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(100);
            q.Enqueue(1000);
            var item = q.Dequeue(); //removes it
            Debug.WriteLine($"Removed Item: {item}");
            var peekItem = q.Peek(); //next element withou removing it
            Debug.WriteLine($"Peek Item: {peekItem}");
            foreach (var itemNum in q)
            {
                Debug.WriteLine($"Queue Item: {itemNum}");
            }
        }
    }
}