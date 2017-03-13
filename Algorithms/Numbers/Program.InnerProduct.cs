using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void InnerProduct()
        {
            var a = new int[] {1, 2, 3};
            var b = new int[] {1, 10, 100};
            var sum = 0;
            for (var x = 0; x < a.Length; x++)
                sum += a[x] * b[x];

            Debug.WriteLine($"total Inneer Product: {sum}");
        }
    }
}