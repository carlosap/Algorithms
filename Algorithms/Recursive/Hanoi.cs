using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        //Recursive Hanoi
        public static void Hanoi(int num, char x, char y, char z)
        {
            if (num == 1)
            {
                Debug.WriteLine($"Move Top Disk from Peg {x} to peg {z}");
            }
            else
            {
                Hanoi(num - 1, x, z, y);
                Hanoi(1, x, y, z);
                Hanoi(num - 1, y, x, z);
            }
        }
    }
}