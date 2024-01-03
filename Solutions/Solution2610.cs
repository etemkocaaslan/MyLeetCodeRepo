namespace leetcode.Solutions
{
    public class Solution2610
    {
        public IList<IList<int>> FindMatrix(int[] nums)
        {
            List<int> container = new();
            List<int> matrix = nums.ToList();

            IList<IList<int>> list = new List<IList<int>>();
            while (matrix.Count > 0)
            {
                for (int i = 0; i < matrix.Count; i++)
                {
                    if (container.Count == 0 || !container.Contains(matrix[i]))
                    {
                        container.Add(matrix[i]);
                        matrix.Remove(matrix[i]);
                        i--;
                    }

                }
                list.Add(container.ToArray());
                container.Clear();
            }
            return list;
        }
    }
}
