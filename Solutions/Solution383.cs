using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution383
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            List<char> list = new List<char>(magazine);

            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (!list.Remove(ransomNote[i]))
                    return false;
            }
            return true;
        }
    }
}
