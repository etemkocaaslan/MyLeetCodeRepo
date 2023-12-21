namespace leetcode.Solutions
{
    class Solution1637
    {
        public int MaxWidthOfVerticalArea(int[][] points)
        {
            int maxGap = 0;
            int[] xCoordinates = new int[points.Length];

            for (int i = 0; i < points.Length; i++)
                xCoordinates[i] = points[i][0];

            Array.Sort(xCoordinates);

            for (int i = 1; i < points.Length; ++i)
                maxGap = (xCoordinates[i] - xCoordinates[i - 1] > maxGap) ? (xCoordinates[i] - xCoordinates[i - 1]) : maxGap;

            return maxGap;
        }
    }
}
