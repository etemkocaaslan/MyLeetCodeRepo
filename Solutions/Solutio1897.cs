namespace leetcode.Solutions
{
    public class Solution1897
    {
        public bool MakeEqual(string[] words)
        {
            Dictionary<char, int> map = new();

            foreach (string word in words)
            {
                foreach (char c in word)
                {
                    if (map.ContainsKey(c))
                    {
                        map[c]++;
                    }
                    else
                    {
                        map[c] = 1;
                    }
                }
            }

            foreach (int count in map.Values)
            {
                if (count % words.Length != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
