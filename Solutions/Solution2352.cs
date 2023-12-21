using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution2352
    {
        public int EqualPairs(int[][] grid)
        {
            int count = 0;
            int[] cols = new int[grid.Length];
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                    cols[j] = grid[j][i];
                for (int k = 0; k < cols.Length; k++)
                    if (cols.SequenceEqual(grid[k]))
                        count++;
            }
            return count;
        }
    }
}
