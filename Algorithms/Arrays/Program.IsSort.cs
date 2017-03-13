using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void IsSort()
        {
            var results = true;
            var data = new int[] {1, 2, 3, 4, 5};
            for (var x = 1; x < data.Length; x++)
            {
                if (data[x - 1] > data[x])
                {
                    results = false;
                    break;
                }
            }
            Debug.WriteLine($"Is the Array Sorted: {results}");
        }
    }
}