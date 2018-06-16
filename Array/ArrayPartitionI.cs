using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// 561.  Array Partition 1
/// </summary>

namespace ConsoleApp4
{
    class ArrayPartitionI
    {
        public static int ArrayPairSum(int[] nums)
        {
            int sum = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i += 2)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
