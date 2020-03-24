/******************************************************************************
Problem- prime numbers are natural numbers (1,2,3..) 
divisile by exactly 2 natural numbers: itself or 1.
Examples
Is:
        3
       / \
      1   3

        2
       / \
      1   2

Not
        4
      / | \
      1 2  4

If you think about computer science, prime numbers gives you a building block mechamism 
to find  a complete Node (by left and right node).
*******************************************************************************/
namespace Algorithms
{
    partial class Program
    {
        public static bool IsPrime(int val)
        {
            if (val < 2) return false;
            if (val == 2) return true;
            if (val % 2 == 0) return false;
            for (int k = 3; k < val; k += 2)
                if (val % k == 0) return false;

            return true;
        }
    }
}