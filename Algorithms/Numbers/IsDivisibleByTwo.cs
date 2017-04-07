/* **************************************************************************
 * Any whole number that ends in 0, 2, 4, 6, or 8 will be divisible by 2.
 * Here the divisibility test is done by performing the mod function with 2.
 *****************************************************************************/
namespace Algorithms
{
    partial class Program
    {
        public static bool IsDivisbleByTwo(int val)
        {
            
            return val % 2 == 0;

        }
    }
}
