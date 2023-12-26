namespace leetcode.Solutions
{
    public class Solution257
    {
        //.. Different Approachment

        //public IList<string> BinaryTreePaths(TreeNode root)
        //{
        //    List<string> paths = new List<string>();
        //    string s = "";

        //    FindPath(root, s);

        //    void FindPath(TreeNode root, string s1)
        //    {
        //        if (root != null)
        //        {
        //            if (root.left == null && root.right == null)
        //            {
        //                s1 = s1 + root.val;
        //                paths.Add(s1);
        //            }
        //            else
        //            {
        //                s1 = s1 + root.val + "->";
        //                FindPath(root.left, s1);
        //                FindPath(root.right, s1);
        //            }
        //        }
        //    }

        //    return paths;
        //}
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

        public IList<string> BinaryTreePaths(TreeNode root)
        {
            IList<string> leftPath = new List<string>();
            IList<string> rightPath = new List<string>();

            if (root.left != null)
            {
                leftPath = BinaryTreePaths(root.left);
                for (int i = 0; i < leftPath.Count; i++)
                    leftPath[i] = root.val + "->" + leftPath[i];
            }
            else if (root.right == null)
            {
                leftPath.Add(root.val.ToString());
                return leftPath;
            }

            if (root.right != null)
            {
                rightPath = BinaryTreePaths(root.right);
                for (int i = 0; i < rightPath.Count; i++)
                    rightPath[i] = root.val + "->" + rightPath[i];
            }
            else if (root.left == null)
            {
                rightPath.Add(root.val.ToString());
                return rightPath;
            }

            return leftPath.Concat(rightPath).ToList();
        }
    }
}
