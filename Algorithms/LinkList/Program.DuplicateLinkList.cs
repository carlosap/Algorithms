using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void DuplicateLinkList()
        {
            LinkedList<string> list = new LinkedList<string>();
            var dict = new Dictionary<string, int>();
            list.AddFirst("first");
            list.AddLast("second");
            list.AddLast("first");
            foreach (var item in list)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict[item] = 1;
                }
            }
            foreach (var item in dict)
            {
                Debug.WriteLine($"Key : {item.Key} Value: {item.Value}");
            }
        }
    }
}