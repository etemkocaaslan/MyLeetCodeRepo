namespace leetcode.Solutions
{
    public class Solution1758
    {
        public int MinOperations(string s)
        {
            int ones = 0;
            int zeros = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                switch (i % 2)
                {
                    case 0:
                        switch (s[i])
                        {
                            case '1':
                                zeros++;
                                break;
                            case '0':
                                ones++;
                                break;

                        }
                        break;
                    case 1:
                        switch (s[i])
                        {
                            case '1':
                                ones++;
                                break;
                            case '0':
                                zeros++;
                                break;

                        }
                        break;
                }
            }
            return Math.Min(ones, zeros);
        }
    }
}
