using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution2482
    {
        public int[][] OnesMinusZeros(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int[][] diff = new int[m][];

            int[] onesRow = new int[m];
            int[] zerosRow = new int[m];
            int[] onesCol = new int[n];
            int[] zerosCol = new int[n];

            for (int i = 0; i < m; ++i)
            {
                diff[i] = new int[n];
                for (int j = 0; j < n; ++j)
                {
                    if (grid[i][j] != 1)
                    {
                        zerosRow[i]++;
                        zerosCol[j]++;
                    }
                    else
                    {
                        onesRow[i]++;
                        onesCol[j]++;
                    }
                }
            }
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    diff[i][j] = onesRow[i] + onesCol[j] - zerosRow[i] - zerosCol[j];
                }
            }
            return diff;
        }
    }
}
