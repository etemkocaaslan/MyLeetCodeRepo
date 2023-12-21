using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution1582
    {
        public int NumSpecial(int[][] mat)
        {
            int[] rSum = new int[mat.Length];
            int[] cSum = new int[mat[0].Length];
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[0].Length; j++)
                {
                    rSum[i] += mat[i][j];
                    cSum[j] += mat[i][j];
                }
            }



            int res = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                if (rSum[i] == 1)
                    for (int j = 0; j < mat[0].Length; j++)
                    {
                        if (mat[i][j] == 1 && cSum[j] == 1)
                            res++;
                    }
            }

            return res;
        }
    }
}
