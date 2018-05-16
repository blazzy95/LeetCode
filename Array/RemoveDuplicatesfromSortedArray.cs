using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// 26. Remove Duplicates from Sorted Array
/// </summary>

namespace RemoveDuplicatesfromSortedArray
{
    class RemoveDuplicatesfromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int first = 0;
            int second = 1;

            if (nums.Length < 2)
                return nums.Length;

            while (second < nums.Length)
            {
                if (nums[first] == nums[second])
                {
                    second++;
                }
                else
                {
                    first++;
                    nums[first] = nums[second];
                    second++;
                }
            }
            return first + 1;
        }
    }
}
