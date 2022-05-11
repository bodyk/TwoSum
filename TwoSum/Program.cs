using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        // Time: O(n)
        // Space: O(n)
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(nums[0], 0);
            for (int i = 1; i < nums.Length; i++)
            {
                var seekingValue = target - nums[i];
                if (dict.ContainsKey(seekingValue))
                {
                    return new int[]
                    {
                            dict[seekingValue],
                            i
                    };
                }
                else if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }
            return new int[0];
        }

        static void Main(string[] args)
        {
            var nums = new int[]
            {
                -3,4,3,90
            };
            var r = TwoSum(nums, 0);
            foreach (var item in r)
            {
                Console.WriteLine(item);
            }
        }
    }
}
