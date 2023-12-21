using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution1436
    {
        public string DestCity(IList<IList<string>> paths)
        {
            string result = "";
            HashSet<string> pathset = new HashSet<string>();
            foreach (IList<string> path in paths)
                pathset.Add(path[0]);

            foreach (IList<string> path in paths)
            {
                if (!pathset.Contains(path[1]))
                {
                    result = path[1];
                    break;
                }
            }

            return result;
        }
    }
}
