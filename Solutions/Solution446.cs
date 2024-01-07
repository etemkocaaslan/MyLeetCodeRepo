namespace leetcode.Solutions
{
    public static class Solution446
    {
        public static int NumberOfArithmeticSlices(int[] nums)
        {
            int result = 0;

            Dictionary<int, int>[] dp = new Dictionary<int, int>[nums.Length];
            for (int i = 0; i < nums.Length; ++i)
                dp[i] = new Dictionary<int, int>();

            for (int i = 1; i < nums.Length; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    long diff = (long)nums[i] - nums[j];
                    if (diff > int.MaxValue || diff < int.MinValue)
                        continue;

                    int diffInt = (int)diff;

                    dp[i][diffInt] = dp[i].GetValueOrDefault(diffInt) + 1;

                    if (dp[j].TryGetValue(diffInt, out int value))
                    {
                        dp[i][diffInt] += value;
                        result += value;
                    }
                }
            }

            return result;
        }
    }
}