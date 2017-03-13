using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void BinarySearchIterative()
        {
            //Make sure Array is Sorted
            var data = new int[] {1, 2, 3, 66, 68, 69};
            var results = -1;
            var key = 66;
            int min = 0;
            int max = data.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == data[mid])
                {
                    results = ++mid;
                    break;
                }
                if (key < data[mid])
                {
                    //left
                    max = mid - 1;
                }
                else
                {
                    //right
                    min = mid + 1;
                }
            }
            Debug.WriteLine(results);
        }
    }
}