using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void KthToLast()
        {
            int results = -1;
            var list1 = new LinkedList<int>();
            list1.AddLast(1);
            list1.AddLast(2);
            list1.AddLast(3);
            var p1 = list1.First; //head -> change to Last for 1st Kth
            var p2 = list1.First; //head -> change to Last for 1st Kth
            //assumption known Size. We are getting ahead by 1
            for (var x = 0; x < list1.Count; x++)
            {
                if (p1 == null)
                {
                    break;
                }
                Debug.WriteLine($"index: {x} = {p1.Value}");
                results = p1.Value;
                p1 = p1.Next; //-> change to Previous for 1st Kth
            }
            //print last value
            Debug.WriteLine(results); //output 3
        }
    }
}