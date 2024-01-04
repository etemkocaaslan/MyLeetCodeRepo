namespace leetcode.Solutions
{
    public class Solution217
    {
        public bool ContainsDuplicate(int[] nums)
        {
            return nums.Length != nums.Distinct().Count();
        }
    }
}
