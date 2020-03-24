using System.Diagnostics;
namespace Algorithms
{
    partial class Program
    {
        public static void SortAsc()
        {
            var data = new int[] {34, 22, 55, 66, 1, 3};
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
            for (var i = 0; i < data.Length; i++)
            {
                Debug.WriteLine(data[i]);
            }
        }
    }
}