using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution606
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public string Tree2str(TreeNode? root)
        {
            if (root == null)
                return "";

            string result = root.val.ToString();

            if (root.left != null || root.right != null)
                result += "(" + Tree2str(root.left) + ")";

            if (root.right != null)
                result += "(" + Tree2str(root.right) + ")";
            return result;
        }
    }
}
