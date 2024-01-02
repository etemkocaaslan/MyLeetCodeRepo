namespace leetcode.Solutions
{
    //public class Solution1624
    //{
    //    public int MaxLengthBetweenEqualCharacters(string s)
    //    {
    //        if (s.Length == 1)
    //            return 0;

    //        if (s.Distinct().ToArray().Length == s.Length)
    //            return -1;

    //        int count = 0;
    //        Dictionary<char, int> map = new Dictionary<char, int>();
    //        for (int position = 0; position < s.Length; ++position)
    //        {
    //            if (map.ContainsKey(s[position]))
    //            {
    //                int nSub = Math.Abs(map[s[position]] - position);
    //                if (nSub > count)
    //                    count = nSub - 1;
    //            }
    //            else
    //            {
    //                map.Add(s[position], position);
    //            }
    //        }

    //        return count;
    //    }
    //}

    public class Solution1624
    {
        public int MaxLengthBetweenEqualCharacters(string s)
        {
            if (s.Length == 1)
                return 0;

            Dictionary<char, int> map = new Dictionary<char, int>();

            int count = 0;
            for (int position = 0; position < s.Length; ++position)
            {
                if (map.ContainsKey(s[position]))
                {
                    if (position - map[s[position]] > count)
                        count = position - map[s[position]] - 1;
                }
                else
                    map.Add(s[position], position);
            }

            return count;
        }
    }
}
