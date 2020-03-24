/***********************************************************************************************************
problem:Factorial of a number is obtained from the result of multiplying a series of descending natural numbers.
a factorial of n items gives you the number of ways you can arrange the given items.
If there are two coins - you can arrange them in two different ways - 
like wise if you have 5 coins - there are 120 ways you can arrange them.

Gambling: In any card game, if you want to calculate the probability of favorable outcomes, you have 
to have a working knowledge of factorials.
************************************************************************************************************/
namespace Algorithms
{
    partial class Program
    {
        public static double GetFactorial(int val)
        {
            if (val == 1)
                return 1;
            return val * GetFactorial(val - 1);
        }
    }
}