namespace leetcode.Solutions
{
    public class Solution1155
    {
        private const int MOD = 1000000007;

        public int NumRollsToTarget(int n, int k, int target)
        {
            int[] dp = new int[target + 1];
            dp[0] = 1;

            for (int dice = 1; dice <= n; dice++)
            {
                int[] newDp = new int[target + 1];
                int cumulative = 0;
                for (int sum = 1; sum <= target; sum++)
                {
                    if (sum - k - 1 >= 0)
                    {
                        cumulative = (cumulative - dp[sum - k - 1] + MOD) % MOD;
                    }
                    cumulative = (cumulative + dp[sum - 1]) % MOD;
                    newDp[sum] = cumulative;
                }
                dp = newDp;
            }

            return dp[target];
        }
    }

}
