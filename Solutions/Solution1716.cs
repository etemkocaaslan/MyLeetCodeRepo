using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution1716
    {
        public int TotalMoney(int n) => Enumerable.Range(1, n).Select((val, index) => (val % 7 == 0 ? 7 : val % 7) + index / 7).Sum();
    }
}
