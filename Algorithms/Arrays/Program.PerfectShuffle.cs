using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void PerfectShuffle()
        {
            var data = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
            var temp = new int[data.Length];
            int mid = data.Length / 2;
            int index = 0;
            //----Left side: 1=1, 3=2, 5=3---------------
            for (var x = 0; x < mid; x++)
            {
                index = 2 * x + 1;
                temp[index] = data[x];
            }
            //----Right side: 0=5, 2=6, 4=7---------------
            for (var x = mid; mid < data.Length; x++)
            {
                index = 2 * (x - mid);
                if (index <= data.Length)
                    temp[index] = data[x];
                else
                    break;
            }
            //----Print Results---------------
            for (var x = 0; x < data.Length; x++)
            {
                data[x] = temp[x];
                Debug.WriteLine(data[x]);
            }
        }
    }
}