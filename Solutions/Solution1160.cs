using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution1160
    {
        public int CountCharacters(string[] words, string chars)
        {
            int result = 0;
            string temp = chars;
            foreach (string word in words)
            {
                int count = 0;
                foreach (char c in word)
                {
                    if (temp.Contains(c))
                    {
                        count++;
                        temp = temp.Remove(temp.IndexOf(c), 1);
                    }
                    else
                        break;
                }
                if (count == word.Length)
                    result += word.Length;
                temp = chars;
            }

            return result;
        }
    }
}
