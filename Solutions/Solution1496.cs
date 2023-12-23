namespace leetcode.Solutions
{
    public class Solution1496
    {
        public bool IsPathCrossing(string path)
        {
            int xAxis = 0;
            int yAxis = 0;
            List<int[]> visited = new()
            {
                {[0, 0]} //Origin
            };

            foreach (char direction in path)
            {
                switch (direction)
                {
                    case ('N'):
                        yAxis++;
                        break;
                    case ('S'):
                        yAxis--;
                        break;
                    case ('E'):
                        xAxis++;
                        break;
                    case ('W'):
                        xAxis--;
                        break;
                    default:
                        break;
                }

                if (visited.Find((cordinates) => cordinates[0] == xAxis & cordinates[1] == yAxis) != null)
                {
                    return true;
                }
                visited.Add(new int[] { xAxis, yAxis });
            }
            return false;
        }
    }
}
