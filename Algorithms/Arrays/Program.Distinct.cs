using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void Distinct()
        {
            var data = new int[] {1, 3, 33, 333, 33, 3, 1, 55};
            Dictionary<int, int> duplicates = new Dictionary<int, int>();
            List<int> distinct = new List<int>();
            for (var x = 0; x < data.Length; x++)
            {
                if (duplicates.ContainsKey(data[x]))
                {
                    duplicates[data[x]]++;
                }
                else
                {
                    distinct.Add(data[x]);
                    duplicates[data[x]] = 1;
                }
            }
            foreach (var item in distinct)
            {
                Debug.WriteLine($"{item}");
            }
        }
    }
}