using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution1
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int pointer = target - nums[i];
                if (map.ContainsKey(pointer))
                {
                    return new int[] { map[pointer], i };
                }
                map[nums[i]] = i;
            }
            return new int[] { 0 };
        }
    }
}
