using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution1688
    {
        public int NumberOfMatches(int n) => (n % 2 == 1) ? (((n - 1) / 2 + NumberOfMatches((n - 1) / 2 + 1))) : ((n > 2) ? n / 2 + NumberOfMatches(n / 2) : 1);
    }
}
