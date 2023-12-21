using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution2264
    {
        public string LargestGoodInteger(string num)
        {
            int target = -1;
            for (int i = 0; i < num.Length - 2; ++i)
            {
                if (num[i] == num[i + 1] && num[i + 1] == num[i + 2])
                {
                    int current = int.Parse(num.Substring(i, 3));
                    if (current > target)
                        target = current;
                }
            }
            return (target != -1) ? ((target == 0) ? target + "00" : target.ToString()) : "";

        }
    }
}
