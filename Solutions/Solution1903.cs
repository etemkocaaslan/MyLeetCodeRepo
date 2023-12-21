using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution1903
    {
        public string LargestOddNumber(string num) => num[..(1 + num.LastIndexOfAny(new[] { '1', '3', '5', '7', '9' }))];
    }
}
