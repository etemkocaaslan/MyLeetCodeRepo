namespace leetcode.Solutions
{
    public class Solution347
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            foreach(int num in nums)
            {
                if (keyValuePairs.TryGetValue(num, out int value))
                {
                    keyValuePairs[num] = ++value;
                }
                else
                {
                    keyValuePairs.Add(num, 0);
                }
            }
            var result = new List<int>();
            foreach(int key in keyValuePairs.Keys)
            {
                if (keyValuePairs[key] >= k)
                {
                    result.Add(key);
                }
            }
            return result.ToArray();
        }
    }
}
