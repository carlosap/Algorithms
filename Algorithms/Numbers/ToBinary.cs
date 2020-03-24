using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static int ToBinary(int num)
        {
            if (num != 0)
            {
                var bin = (num % 2) + 10 * ToBinary(num / 2);
                Debug.Write(bin);
                return 0;
            }
            return 0;
        }
    }
}