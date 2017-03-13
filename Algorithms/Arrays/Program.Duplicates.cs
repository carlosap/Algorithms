using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void Duplicates()
        {
            var data = new int[] {1, 3, 1, 1, 1, 33, 2, 1, 33};
            Dictionary<int, int> duplicates = new Dictionary<int, int>();
            for (var x = 0; x < data.Length; x++)
            {
                if (duplicates.ContainsKey(data[x]))
                {
                    duplicates[data[x]]++;
                }
                else
                {
                    duplicates[data[x]] = 1;
                }
            }
            foreach (var item in duplicates)
            {
                if (item.Value > 1)
                {
                    Debug.WriteLine($"Key {item.Key} Value: {item.Value}");
                }
            }
        }
    }
}