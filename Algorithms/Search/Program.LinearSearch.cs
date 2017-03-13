using System;
using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static int LinearSearch()
        {
            var data = new int[] {1, 2, 3, 4, 68, 69};
            var key = 68;
            Array.Sort(data);
            int StepCounter = 0;
            for (var x = 0; x < data.Length; x++)
            {
                StepCounter++;
                if (data[x] == key)
                {
                    Debug.WriteLine(StepCounter);
                    return StepCounter;
                }
            }
            Debug.WriteLine(-1);
            return -1;
        }
    }
}