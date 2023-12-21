using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution94
    {
        //Definition for a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode? left;
            public TreeNode? right;
            public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> result = new();
            Stack<TreeNode> stack = new();

            var currentnode = root;
            while (currentnode != null || stack.Count != 0)
            {
                if (currentnode != null)
                {
                    stack.Push(currentnode);
                    currentnode = currentnode.left;
                }
                else
                {
                    currentnode = stack.Pop();
                    result.Add(currentnode.val);
                    currentnode = currentnode.right;
                }
            }

            return result;
        }
    }
}
