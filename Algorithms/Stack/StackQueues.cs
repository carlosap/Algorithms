using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void StackQueues()
        {
            Stack<string> book1 = new Stack<string>();
            Stack<string> book2 = new Stack<string>();
            book1.Push("book1-Section-1");
            book1.Push("book1-Section-2");
            book2.Push("book2-Section-1");
            book2.Push("book2-Section-2");
            Queue<Stack<string>> q = new Queue<Stack<string>>();
            q.Enqueue(book1);
            q.Enqueue(book2);
            while (q.Count > 0)
            {
                Stack<string> item = q.Dequeue();
                while (item.Count > 0)
                    Debug.WriteLine(item.Pop());
            }
        }
    }
}