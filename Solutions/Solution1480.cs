using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution1480
    {
        public int[] RunningSum(int[] nums)
        {
            int[] runningSum = new int[nums.Length];

            for (int i = nums.Length; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    runningSum[i - 1] += nums[j];
                }
            }
            return runningSum;
        }
    }
}
