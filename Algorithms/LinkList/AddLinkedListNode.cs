using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void AddLinkedListNode()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("First");
            list.AddLast("Second");
            list.AddLast("third");
            list.AddLast("third");
            foreach (var item in list)
                Debug.WriteLine(item);
        }
    }
}