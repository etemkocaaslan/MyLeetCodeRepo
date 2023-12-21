using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution1611
    {
        public int MinimumOneBitOperations(int n) => (n == 0) ? 0 : n ^ MinimumOneBitOperations(n >> 1);
    }
}
