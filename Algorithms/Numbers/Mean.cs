using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void Mean()
        {
            var data = new int[] {1, 2, 3, 4, 5};
            var total = 0;
            var mean = 0;
            for (var x = 0; x < data.Length; x++)
                total += data[x];

            mean = total / data.Length;
            Debug.WriteLine($"The Mean Value: {mean}");
        }
    }
}