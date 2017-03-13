using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void Max()
        {
            var data = new int[] {1, 3, 5, 63, 75, 3};
            for (var x = 0; x < data.Length; x++)
            {
                for (var y = 0; y < data.Length; y++)
                {
                    if (data[y] > data[x])
                    {
                        var temp = data[x];
                        data[x] = data[y];
                        data[y] = temp;
                    }
                }
            }
            Debug.WriteLine($"The Max Value is: {data[data.Length - 1]}");
        }
    }
}