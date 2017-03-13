using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void AddTwoArrays()
        {
            var a = new int[] {1, 2, 3};
            var b = new int[] {4, 5, 6};
            var data = new int[a.Length + b.Length];
            for (var x = 0; x < data.Length; x++)
            {
                if (x < a.Length)
                {
                    data[x] = a[x];
                }
                else
                {
                    data[x] = b[x - b.Length];
                }
            }
            for (var i = 0; i < data.Length; i++)
            {
                Debug.WriteLine(data[i]);
            }
        }
    }
}