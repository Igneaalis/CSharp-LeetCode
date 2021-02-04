using System;
using System.Collections.Generic;

namespace Leetcode
{

    class Program
    {

        #region Leetcode

        public class Solution
        {
            public static int[] TwoSum(int[] nums, int target)
            {
                var dict = new Dictionary<int, int?>();
                int? no1 = null;
                int? no2 = null;
                for (int index = 0; index < nums.Length; index++)
                {
                    if (dict.TryGetValue(nums[index], out no1))
                    {
                        no1 = dict[nums[index]];
                        no2 = index;
                        break;
                    }
                    dict[target - nums[index]] = index;
                }
                return new int[] { no1 ?? throw new ArgumentException(), no2 ?? throw new ArgumentException() };
            }
        }

        #endregion

        static void Main(string[] args)
        {
            foreach (var value in Solution.TwoSum(new int[] { 3, 6 }, 9))
            {
                Console.WriteLine(value.ToString());
            }

            Console.ReadKey();
        }
    }
}
