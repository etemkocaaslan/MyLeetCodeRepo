using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution1539
    {
        public int FindKthPositive(int[] arr, int k)
        {
            int missingCount = 0,
            currentNumber = 1,
            i = 0;
            while (missingCount < k)
            {
                if (i < arr.Length && arr[i] == currentNumber)
                    i++;
                else
                {
                    missingCount++;
                    if (missingCount == k)
                        return currentNumber;
                }
                currentNumber++;
            }

            return -1;
        }
    }
}
