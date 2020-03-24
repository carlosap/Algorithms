


namespace Algorithms
{
    using System;
    partial class Program
    {
        static void Main(string[] args)
        {
            var nums = new[] {2, 7, 11, 15};
            var target = 9;
            var retVal = TwoSum(nums, target);
            Console.WriteLine($"Two Sum value {string.Join(",",retVal)}");
            
            Console.ReadLine();

        }
    }
}
