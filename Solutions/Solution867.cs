using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution867
    {
        public int[][] Transpose(int[][] matrix)
        {
            int[][] results = new int[matrix[0].Length][];

            for (int i = 0; i < matrix[0].Length; i++)
                results[i] = new int[matrix.Length];

            for (int row = 0; row < matrix.Length; row++)
                for (int column = 0; column < matrix[0].Length; column++)
                    results[column][row] = matrix[row][column];

            return results;
        }
    }
}
