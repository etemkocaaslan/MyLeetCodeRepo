using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution205
    {
        public int PivotIndex(int[] nums)
        {
            int totalSum = 0;
            for (int i = 0; i < nums.Length; i++) totalSum += nums[i];
            int leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (totalSum - nums[i] == leftSum * 2) return i;
                leftSum += nums[i];
            }
            return -1;
        }
    }
}
