/*
 * Given an array of integers, return indices of the two numbers such that they add up to a specific target.
 * You may assume that each input would have exactly one solution, and you may not use the same element twice.

    Given nums = [2, 7, 11, 15], target = 9,
    Because nums[0] + nums[1] = 2 + 7 = 9,
    return [0, 1].

    Example:
 
                var nums = new[] {2, 7, 11, 15};
                var target = 9;
                var retVal = TwoSum(nums, target);
                Console.WriteLine($"Two Sum value {string.Join(",",retVal)}");

 ****************************************************************************************************************/

namespace Algorithms
{
    using System.Collections;
    public partial class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var diffs = new Hashtable();

            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                var difference = target - nums[i];

                if (diffs.ContainsKey(difference))
                    return new[] {i, (int) diffs[difference]};

                if (!diffs.ContainsKey(num))
                    diffs.Add(num, i);
            }

            return null;
        }
    }
}