using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void ReverseLinkedList()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("First");
            list.AddLast("Second");
            list.AddLast("Third");
            foreach (var item in list)
                Debug.WriteLine(item);

            var temp = new LinkedList<string>();
            var startPointer = list.Last;
            while (startPointer != null)
            {
                temp.AddLast(startPointer.Value);
                startPointer = startPointer.Previous;
            }

            foreach (var item in temp)
                Debug.WriteLine(item);
        }
    }
}