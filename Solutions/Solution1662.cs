using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution1662
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2) => string.Concat(word1) == string.Concat(word2);
    }
}
