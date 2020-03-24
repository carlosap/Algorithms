using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void ReverseNumber()
        {
            var data = new int[] {1, 2, 3, 4};
            for (var x = 0; x < data.Length / 2; x++)
            {
                var temp = data[x];
                data[x] = data[data.Length - 1 - x];
                data[data.Length - 1 - x] = temp;
            }
            for (var x = 0; x < data.Length; x++)
            {
                Debug.WriteLine(data[x]);
            }
        }
    }
}