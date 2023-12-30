namespace leetcode.Solutions
{
    public class Solution1335
    {
        public int MinDifficulty(int[] jobDifficulty, int d)
        {
            int[,] dynamicP = new int[d + 1, jobDifficulty.Length + 1];
            for (int i = 0; i <= d; i++)
                for (int j = 0; j < jobDifficulty.Length; j++)
                    dynamicP[i, j] = Int32.MaxValue;

            for (int day = 1; day <= d; day++)
                for (int i = 0; i < jobDifficulty.Length - day + 1; i++)
                {
                    int difficult = 0;
                    for (int j = i + 1; j < jobDifficulty.Length - day + 2; j++)
                    {
                        difficult = Math.Max(difficult, jobDifficulty[j - 1]);
                        if (dynamicP[day - 1, j] != Int32.MaxValue)
                        {
                            int current = difficult + dynamicP[day - 1, j];
                            dynamicP[day, i] = Math.Min(dynamicP[day, i], current);
                        }
                    }
                }
            return dynamicP[d, 0] < Int32.MaxValue ? dynamicP[d, 0] : -1;
        }
    }
}
