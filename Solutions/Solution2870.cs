namespace leetcode.Solutions
{
    public class Solution2870
    {
        public int MinOperations(int[] nums)
        {
            int result = 0;
            Dictionary<int, int> map = new();
            int[,] ints = new int[nums.Length, 2];
            foreach (int num in nums)
            {
                if (map.ContainsKey(num))
                {
                    map[num]++;
                }
                else
                {
                    map.Add(num, 1);
                }
            }
            foreach (KeyValuePair<int, int> num in map)
            {
                if (num.Value == 1)
                {
                    return -1;
                }

                result += num.Value / 3;
                result += num.Value % 3 != 0 ? 1 : 0;
            }
            return result;
        }
    }
    public class Solution2870_2
    {
        public int MinOperations(int[] nums) => (nums.GroupBy(x => x).Select(g => g.Count()).ToList()).Min() == 1 ? -1 : nums.GroupBy(x => x).Select(g => g.Count()).Sum(cur => cur / 3 + (cur % 3 > 0 ? 1 : 0));
    }
}
