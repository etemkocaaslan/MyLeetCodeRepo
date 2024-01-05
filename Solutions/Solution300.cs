namespace leetcode.Solutions
{
    public class Solution300
    {
        public int LengthOfLIS(int[] nums)
        {
            var dynamicP = new int[nums.Length];
            var result = 0;

            foreach (int num in nums)
            {
                var i = Array.BinarySearch(dynamicP, 0, result, num);
                if (i < 0)
                    i = ~i;

                if (i == result)
                    result++;
                dynamicP[i] = num;
            }

            return result;
        }
    }
}
