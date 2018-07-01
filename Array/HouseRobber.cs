using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// 198. House Robber
/// </summary>

namespace ConsoleApp4
{
    class HouseRobber
    {
        public static int Rob(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            else if (nums.Length == 0)
                return 0;
            else if (nums.Length == 2)
                return Math.Max(nums[0], nums[1]);

            int[] dp = new int[nums.Length];
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < nums.Length; i++)
            {
                dp[i] = Math.Max(dp[i-2]+nums[i], dp[i-1]);
            }
            return dp[dp.Length-1];
        }
    }
}
