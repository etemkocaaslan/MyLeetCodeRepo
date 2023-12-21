using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution1464
    {
        public int FindSpecialInteger(int[] arr)
        {
            int count = arr.Length / 4;
            int current = arr[0];
            int currentCount = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != current)
                {
                    current = arr[i];
                    currentCount = 1;
                }
                else
                {
                    currentCount++;
                    if (currentCount > count)
                        return current;
                }
            }
            return current;
        }
    }
}
