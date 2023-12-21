namespace leetcode.Solutions
{
    public class Solution1913
    {
        public int MaxProductDifference(int[] nums)
        {
            var a = nums.ToList<int>();
            a.Sort();
            return (a[^2] * a[^1]) - (a[0] * a[1]);
        }
    }
}
