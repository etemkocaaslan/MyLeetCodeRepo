using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution252
    {
        public bool IsAnagram(string s, string t)
        {
            char[] a = s.ToArray();
            char[] b = t.ToArray();

            Array.Sort(a);
            Array.Sort(b);

            return a.SequenceEqual(b);
        }
    }
}
