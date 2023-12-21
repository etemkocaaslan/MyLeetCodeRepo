using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution9
    {
        public bool IsPalindrome(int x) => x.ToString().Equals(new string(x.ToString().Reverse().ToArray()));

    }
}
