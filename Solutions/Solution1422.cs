using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution1442
    {
        public int MaxScore(string s)
        {
            int maxScore = 0;
            int countZerosLeft = 0;
            int countOnesRight = s.Split('1').Length - 1;

            for (int i = 0; i < s.Length - 1; i++)
            {
                countZerosLeft += s[i] == '0' ? 1 : 0;
                countOnesRight -= s[i] == '1' ? 1 : 0;
                maxScore = Math.Max(maxScore, countZerosLeft + countOnesRight);
            }

            return maxScore;
        }
    }
}
