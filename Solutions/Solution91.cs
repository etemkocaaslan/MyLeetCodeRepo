namespace leetcode.Solutions
{
    public class Solution91
    {
        public int NumDecodings(string s)
        {
            var dynamicP = Enumerable.Repeat(-1, s.Length).ToArray();
            return GetWays(s, 0, dynamicP);
        }

        int GetWays(string s, int pos, int[] dp)
        {
            if (pos == s.Length)
            {
                return 1;
            } 
                
            if (s[pos] == '0')
            {
                return 0;
            }
            if (dp[pos] != -1)
            {
                return dp[pos];
            }
            
            int decodeWays = GetWays(s, pos + 1, dp);
            
            if (pos < s.Length - 1 && Convert.ToInt32(s.Substring(pos, 2)) <= 26)
            {
                decodeWays += GetWays(s, pos + 2, dp);
            }
            return dp[pos] = decodeWays;
        }
    }
}
