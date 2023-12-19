namespace leetcode.Solutions
{
    public class Solution661
    {
        public int[][] ImageSmoother(int[][] img)
        {
            int rows = img.Length;
            int cols = img[0].Length;
            int[][] result = new int[rows][];

            for (int row = 0; row < rows; ++row)
            {
                result[row] = new int[cols];

                for (int col = 0; col < cols; ++col)
                {
                    int totalSum = 0;
                    int count = 0;
                    for (int x = Math.Max(0, row - 1); x < Math.Min(rows, row + 2); ++x)
                    {
                        for (int y = Math.Max(0, col - 1); y < Math.Min(cols, col + 2); ++y)
                        {
                            totalSum += img[x][y];
                            count += 1;
                        }
                    }

                    int avarage = totalSum / count;
                    result[row][col] = avarage;
                }
            }

            return result;
        }
    }
}