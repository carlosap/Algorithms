/***********************************************************************************************************
The factors of a number are all those numbers that can divide evenly 
into the number with no remainder.
************************************************************************************************************/

using System;

namespace Algorithms
{
    partial class Program
    {
        public static void GetFactorOfNumber(int val)
        {
            for (var i = 1; i <= val; i++)
            {
                if (val % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}