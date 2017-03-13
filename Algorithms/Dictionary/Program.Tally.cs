using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void Tally()
        {
            var data = new[] {"test", "cars", "test"};
            var dict = new Dictionary<string, int>();
            for (var x = 0; x < data.Length; x++)
            {
                if (dict.ContainsKey(data[x]))
                {
                    dict[data[x]]++;
                }
                else
                {
                    dict[data[x]] = 1;
                }
            }
            foreach (var item in dict)
            {
                Debug.WriteLine($"word: {item.Key} count: {item.Value}");
            }
        }
    }
}