using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution228
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return new List<string>();

            if (nums.Length == 1)
                return new List<string>() { nums[0].ToString() };

            var result = new List<string>();

            int start = nums[0];
            int previous = start;
            for (int i = 1; i < nums.Length; ++i)
            {
                int current = nums[i];
                if (current != previous + 1)
                {
                    if (start == previous)
                        result.Add(previous.ToString());
                    else
                        result.Add(start + "->" + previous);

                    if (nums.Length - 1 == i)
                        result.Add(current.ToString());

                    start = current;
                }
                else if (nums.Length - 1 == i)
                    result.Add(start + "->" + current.ToString());

                previous = current;
            }

            return result;
        }
    }
}
