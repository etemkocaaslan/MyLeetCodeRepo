using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution1727
    {
        public int HammingWeight(uint n) => Convert.ToString(n, 2).Count((x) => x == '1');
    }
}
