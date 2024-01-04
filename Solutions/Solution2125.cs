namespace leetcode.Solutions
{
    public class Solution2125
    {
        public int NumberOfBeams(string[] bank)
        {
            int result = 0;
            List<int> security = new();
            for (int i = 0; i < bank.Length; ++i)
            {
                int curr = bank[i].Count(x => x == '1');
                if (curr != 0)
                {
                    security.Add(curr);
                }
                if (security.Count == 2)
                {
                    result += security[0] * security[1];
                    security[0] = security[1];
                    security.RemoveAt(0);
                }
            }
            return result;
        }
    }
    public class Solution2125_2
    {
        public int NumberOfBeams(string[] bank)
        {
            int[] numOfCam = bank.Select(r => r.Count(d => d == '1')).Where(cnt => cnt > 0).ToArray();
            int result = 0;
            for (int i = 1; i < numOfCam.Length; ++i) 
                result += numOfCam[i] * numOfCam[i - 1];
            return result;
        }
    }
}

