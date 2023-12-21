using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution2849
    {
        public bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t)
        {
            if (sx == fx && sy == fy)
                return t > 1 || t == 0;

            return t >= Math.Max(Math.Abs(fx - sx), Math.Abs(fy - sy));
        }
    }
}
