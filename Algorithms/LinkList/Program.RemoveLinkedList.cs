using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void RemoveLinkedList()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("First");
            list.AddLast("Second");
            list.AddLast("Third");
            var delete = list.Find("Second");
            if (delete != null)
            {
                list.Remove(delete);
            }
            foreach (var item in list)
            {
                Debug.WriteLine(item);
            }
        }
    }
}