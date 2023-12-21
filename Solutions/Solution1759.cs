using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution1759
    {
        public int CountHomogenous(string s)
        {
            long count = 0;
            int mod = 1000000007;
            int consecutive = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    consecutive++;
                }
                else
                {
                    count += (long)consecutive * (consecutive + 1) / 2;
                    consecutive = 1;
                }
            }

            count += (long)consecutive * (consecutive + 1) / 2;
            return (int)(count % mod);
        }
    }
}
