namespace leetcode.Solutions
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> dict = new();

            for (int i = 0; i < strs.Length; i++)
            {
                char[] arr = strs[i].ToCharArray();
                Array.Sort(arr);

                if (!dict.TryGetValue(new String(arr), out IList<string>? value))
                    dict.Add(new String(arr), new List<String>() { strs[i] });
                else
                    value.Add(strs[i]);
            }

            return dict.Values.ToList();
        }
    }
}