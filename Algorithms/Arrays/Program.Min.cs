using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void Min()
        {
            var data = new int[] {1, 30, 9, 434, 3};
            for (var x = 0; x < data.Length; x++)
            {
                for (var y = 0; y < data.Length; y++)
                {
                    if (data[y] < data[x])
                    {
                        var temp = data[x];
                        data[x] = data[y];
                        data[y] = temp;
                    }
                }
            }
            Debug.WriteLine($"The Min Value is: {data[data.Length - 1]}");
        }
    }
}