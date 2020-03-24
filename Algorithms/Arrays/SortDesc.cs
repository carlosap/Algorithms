using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void SortDesc()
        {
            var data = new[] {44, 23, 55, 1};
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

            for (var i = 0; i < data.Length; i++) 
                Debug.WriteLine(data[i]);
        }
    }
}