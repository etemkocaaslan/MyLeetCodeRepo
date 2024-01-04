namespace leetcode.Solutions
{
    public class Solution252
    {
        public bool IsAnagram(string s, string t)
        {
            char[] a = s.ToArray();
            char[] b = t.ToArray();

            Array.Sort(a);
            Array.Sort(b);

            return a.SequenceEqual(b);
        }
    }
}
