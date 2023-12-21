using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution1266
    {
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            int time = 0;
            for (int i = 0; i < points.Length - 1; ++i)
            {
                int deltaX = Math.Abs(points[i][0] - points[i + 1][0]);
                int deltaY = Math.Abs(points[i][1] - points[i + 1][1]);
                time += Math.Max(deltaX, deltaY);
            }
            return time;
        }
    }
}
