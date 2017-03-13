using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void RemoveDuplicates()
        {
            var list = new LinkedList<int>();
            var temp = new LinkedList<int>();
            var dict = new Dictionary<int, int>();
            list.AddFirst(1);
            list.AddLast(3);
            list.AddLast(2);
            list.AddLast(3);
            foreach (var item in list)
            {
                if (dict.ContainsKey(item))
                    dict[item]++;
                else
                {
                    dict[item] = 1;
                    temp.AddLast(item);
                }
            }
            foreach (var item in temp)
                Debug.WriteLine($"{item}");
        }
    }
}