using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void OuterProduct()
        {
            var a = new int[] {1, 2, 3, 4};
            var b = new int[] {10, 3, 4, 4};
            var data = new int[a.Length, b.Length];
            for (var x = 0; x < a.Length; x++)
            {
                for (var y = 0; y < b.Length; y++)
                {
                    data[x, y] = a[x] * b[y];
                    Debug.WriteLine(data[x, y]);
                }
            }
        }
    }
}