namespace leetcode.Solutions
{
    public class Solution1531
    {
        public int GetLengthOfOptimalCompression(string s, int k)
        {
            int[][] dynamicP = new int[s.Length + 1][];

            for (var i = 0; i < dynamicP.Length; i++)
            {
                dynamicP[i] = new int[k + 1];
                Array.Fill(dynamicP[i], s.Length);
            }

            dynamicP[0][0] = 0;

            for (var x = 1; x <= s.Length; x++)
                for (var y = 0; y <= k; y++)
                    UpdateDP(dynamicP, s, y, x);

            return dynamicP[s.Length][k];
        }

        private static void UpdateDP(int[][] dynamicP, string s, int y, int x)
        {
            if (y > 0)
            {
                dynamicP[x][y] = Math.Min(dynamicP[x][y], dynamicP[x - 1][y - 1]);
            }

            int same = 0, diff = 0;

            for (int z = x; z >= 1; z--)
            {
                if (s[z - 1] == s[x - 1])
                {
                    same++;
                }
                else
                {
                    diff++;
                }

                if (diff > y)
                {
                    break;
                }

                dynamicP[x][y] = Math.Min(dynamicP[x][y], dynamicP[z - 1][y - diff] + GetLength(same));
            }
        }

        private static int GetLength(int count)
        {
            return count switch
            {
                1 => 1,
                < 10 => 2,
                < 100 => 3,
                _ => 4
            };
        }
    }
}
