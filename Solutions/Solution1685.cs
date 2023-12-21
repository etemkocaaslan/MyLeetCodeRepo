using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution1685
    {
        public static int[] GetSumAbsoluteDifferences(int[] nums)
        {
            int[] result = new int[nums.Length];

            int[] sumAbsoluteDifferences_left = new int[nums.Length];
            int previousValue = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                    sumAbsoluteDifferences_left[i] = 0;
                else
                    sumAbsoluteDifferences_left[i] = sumAbsoluteDifferences_left[i - 1] + Math.Abs(previousValue - nums[i]) * i;

                previousValue = nums[i];
            }


            int[] sumAbsoluteDifferences_right = new int[nums.Length];
            previousValue = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i == nums.Length - 1)
                    sumAbsoluteDifferences_right[i] = 0;
                else
                    sumAbsoluteDifferences_right[i] = sumAbsoluteDifferences_right[i + 1] + Math.Abs(previousValue - nums[i]) * (nums.Length - 1 - i);

                result[i] = sumAbsoluteDifferences_left[i] + sumAbsoluteDifferences_right[i];

                previousValue = nums[i];
            }

            return result;
        }
    }
}
