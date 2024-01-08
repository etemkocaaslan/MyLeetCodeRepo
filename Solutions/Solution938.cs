namespace leetcode.Solutions
{
    public class Solution938
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

        public int RangeSumBST(TreeNode root, int low, int high)
        {
            return (root == null) ? 0 : (((root.val <= high && root.val >= low) ? root.val : 0) + RangeSumBST(root.left, low, high) + RangeSumBST(root.right, low, high));
        }
    }
}
