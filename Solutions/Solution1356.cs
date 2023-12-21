using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution1356
    {
        public int[] SortByBits(int[] arr)
        {
            Array.Sort(arr);
            return arr.OrderBy(i => Convert.ToString(i, 2).Count(digit => digit == '1')).ToArray();
        }
    }
}
