using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace leetcode
{
    #region 
    public class Solution1480
    {
        public int[] RunningSum(int[] nums)
        {
            int[] runningSum = new int[nums.Length];

            for (int i = nums.Length; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    runningSum[i - 1] += nums[j];
                }
            }
            return runningSum;
        }
    }
    #endregion

    #region 
    public class Solution205
    {
        public int PivotIndex(int[] nums)
        {
            int totalSum = 0;
            for (int i = 0; i < nums.Length; i++) totalSum += nums[i];
            int leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (totalSum - nums[i] == leftSum * 2) return i;
                leftSum += nums[i];
            }
            return -1;
        }
    }
    #endregion

    #region
    public class Solution
    {
        public int FindKthPositive(int[] arr, int k)
        {
            int[] missingint = new int[1000];

            if (arr[0] != 1)
                missingint[0] = 1;

            for (int i = 0; i < arr.Length;)
            {
                if (arr[i] + 1 != arr[i + 1])
                {
                    missingint[i] = arr[i] + 1;
                    for (int j = 0; j < arr[i + 1] - arr[i]; j++)
                    {
                        missingint[i + 1 + j] += missingint[i + j];
                    }
                }
            }

            return missingint[k];
        }
    }
    #endregion

    #region 
    //public class Solution1768
    //{
    //    public string MergeAlternately(string word1, string word2)
    //    {
    //        string additionalWords = "";
    //        if ((word1.Length - word2.Length) == 0)
    //        {

    //        }

    //        return "";
    //    }
    //}
    #endregion

    #region 
    public class Solution1672
    {
        public int MaximumWealth(int[][] accounts)
        {
            int RichestCustomerWealth = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                int Wealth = 0;
                Array.ForEach(accounts[i], value => Wealth += value);

                if (Wealth > RichestCustomerWealth)
                    RichestCustomerWealth = Wealth;
            }
            return RichestCustomerWealth;
        }
    }
    #endregion

    #region 
    public class Solution412
    {
        //Given an integer n, return a string array answer(1-indexed) where:

        //answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
        //answer[i] == "Fizz" if i is divisible by 3.
        //answer[i] == "Buzz" if i is divisible by 5.
        //answer[i] == i(as a string) if none of the above conditions are true.

        public IList<string> FizzBuzz(int n)
        {
            var list = new List<string>(n);
            for (int i = 1; i <= n; i++)
            {
                string item = (i % 3 == 0, i % 5 == 0) switch
                {
                    (true, true) => "FizzBuzz",
                    (true, false) => "Fizz",
                    (false, true) => "Buzz",
                    (false, false) => i.ToString(),
                };

                list.Add(item);
            }

            return list;
        }

    }
    #endregion

    #region 
    public class Solution876
    {
        //Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode? MiddleNode(ListNode head)
        {
            ListNode currentNode1 = head;
            int count1 = 0;
            while (currentNode1 != null)
            {
                currentNode1 = currentNode1.next;
                count1++;
            }
            ListNode currentNode2 = head;
            int count2 = 0;
            while (true)
            {
                if (count2 == count1 / 2)
                    return currentNode2;

                currentNode2 = currentNode2.next;
                count2++;
            }
        }
    }
    #endregion

    #region 
    public class Solution383
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            List<char> list = new List<char>(magazine);

            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (!list.Remove(ransomNote[i]))
                    return false;
            }
            return true;
        }
    }
    #endregion

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

    
    public class Solution228
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return new List<string>();

            if (nums.Length == 1)
                return new List<string>() { nums[0].ToString() };

            var result = new List<string>();

            int start = nums[0];
            int previous = start;
            for (int i = 1; i < nums.Length; ++i)
            {
                int current = nums[i];
                if (current != previous + 1)
                {
                    if (start == previous)
                        result.Add(previous.ToString());
                    else
                        result.Add(start + "->" + previous);

                    if (nums.Length - 1 == i)
                        result.Add(current.ToString());

                    start = current;
                }
                else if (nums.Length - 1 == i)
                    result.Add(start + "->" + current.ToString());

                previous = current;
            }

            return result;
        }
    }
    

    
    public class Solution2849
    {
        public bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t)
        {
            if (sx == fx && sy == fy)
                return t > 1 || t == 0;

            return t >= Math.Max(Math.Abs(fx - sx), Math.Abs(fy - sy));
        }
    }
    

    
    public class Solution2352
    {
        public int EqualPairs(int[][] grid)
        {
            int count = 0;
            int[] cols = new int[grid.Length];
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                    cols[j] = grid[j][i];
                for (int k = 0; k < cols.Length; k++)
                    if (cols.SequenceEqual(grid[k]))
                        count++;
            }
            return count;
        }
    }
    
    
    public class Solution1356
    {
        public int[] SortByBits(int[] arr)
        {
            Array.Sort(arr);
            return arr.OrderBy(i => Convert.ToString(i, 2).Count(digit => digit == '1')).ToArray();
        }
    }
    

    
    public class Solution9
    {
        public bool IsPalindrome(int x) => x.ToString().Equals(new string(x.ToString().Reverse().ToArray()));

    }

    public class Solution141
    {
        public class ListNode(int x)
        {
            public int val = x;
            public ListNode? next = null;
        }

        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> visited = new();
            ListNode? current_node = head;
            while (current_node != null)
            {
                if (visited.Contains(current_node))
                    return true;
                visited.Add(current_node);
                current_node = current_node.next;
            }
            return false;
        }
    }
    

    #region 
    //public class Solution1759
    //{
    //    public int CountHomogenous(string s)
    //    {
    //        long count = 0;
    //        int mod = 1000000007;
    //        int consecutive = 1;

    //        for (int i = 1; i < s.Length; i++)
    //        {
    //            if (s[i] == s[i - 1])
    //            {
    //                consecutive++;
    //            }
    //            else
    //            {
    //                count += (long)consecutive * (consecutive + 1) / 2;
    //                consecutive = 1;
    //            }
    //        }

    //        count += (long)consecutive * (consecutive + 1) / 2;
    //        return (int)(count % mod);
    //    }
    //}
    #endregion

    #region 
    //public class Solution1685
    //{
    //    public static int[] GetSumAbsoluteDifferences(int[] nums)
    //    {
    //        int[] result = new int[nums.Length];

    //        int[] sumAbsoluteDifferences_left = new int[nums.Length];
    //        int previousValue = 0;
    //        for (int i = 0; i < nums.Length; i++)
    //        {
    //            if (i == 0)
    //                sumAbsoluteDifferences_left[i] = 0;
    //            else
    //                sumAbsoluteDifferences_left[i] = sumAbsoluteDifferences_left[i - 1] + Math.Abs(previousValue - nums[i]) * i;

    //            previousValue = nums[i];
    //        }


    //        int[] sumAbsoluteDifferences_right = new int[nums.Length];
    //        previousValue = 0;
    //        for (int i = nums.Length - 1; i >= 0; i--)
    //        {
    //            if (i == nums.Length - 1)
    //                sumAbsoluteDifferences_right[i] = 0;
    //            else
    //                sumAbsoluteDifferences_right[i] = sumAbsoluteDifferences_right[i + 1] + Math.Abs(previousValue - nums[i]) * (nums.Length - 1 - i);

    //            result[i] = sumAbsoluteDifferences_left[i] + sumAbsoluteDifferences_right[i];

    //            previousValue = nums[i];
    //        }

    //        return result;
    //    }
    //}
    #endregion

    #region 
    //public class Solution1727
    //{
    //    public int HammingWeight(uint n) => Convert.ToString(n, 2).Count((x) => x == '1');

    //}
    #endregion

    #region . Bus Routes
    //public class Solution815
    //{
    //    public int NumBusesToDestination(int[][] routes, int source, int target)
    //    {
    //        if (source == target)
    //            return 0;

    //        Dictionary<int, List<int>> stopToBuses = new Dictionary<int, List<int>>();

    //        for (int i = 0; i < routes.Length; i++)
    //        {
    //            foreach (int stop in routes[i])
    //            {
    //                if (!stopToBuses.ContainsKey(stop))
    //                    stopToBuses[stop] = new List<int>();

    //                stopToBuses[stop].Add(i);
    //            }
    //        }

    //        Queue<int> stopsQueue = new Queue<int>();
    //        HashSet<int> exploredStops = new HashSet<int>();
    //        HashSet<int> exploredRoutes = new HashSet<int>();

    //        stopsQueue.Enqueue(source);
    //        exploredStops.Add(source);

    //        int numBuses = 0;

    //        while (stopsQueue.Count > 0)
    //        {
    //            int stopsToExplore = stopsQueue.Count;

    //            for (int i = 0; i < stopsToExplore; i++)
    //            {
    //                int currentExploringStop = stopsQueue.Dequeue();
    //                List<int> busesAtCurrentStop = stopToBuses.ContainsKey(currentExploringStop) ? stopToBuses[currentExploringStop] : new List<int>();

    //                foreach (int busAtCurrentStop in busesAtCurrentStop)
    //                {
    //                    if (exploredRoutes.Contains(busAtCurrentStop)) 
    //                        continue;

    //                    exploredRoutes.Add(busAtCurrentStop);

    //                    foreach (int nextExploringStop in routes[busAtCurrentStop])
    //                    {
    //                        if (exploredStops.Contains(nextExploringStop))
    //                            continue;

    //                        exploredStops.Add(nextExploringStop);

    //                        if (nextExploringStop == target)
    //                            return numBuses + 1;

    //                        stopsQueue.Enqueue(nextExploringStop);
    //                    }
    //                }
    //            }
    //            numBuses++;
    //        }   

    //        return -1;
    //    }
    //}
    #endregion

    #region 
    //public class Solution1
    //{
    //    public static int[] TwoSum(int[] nums, int target)
    //    {
    //        Dictionary<int, int> map = new Dictionary<int, int>();

    //        for(int i = 0; i< nums.Length; i++)
    //        {
    //            int pointer = target - nums[i];
    //            if (map.ContainsKey(pointer))
    //            {
    //                return new int[] { map[pointer], i };
    //            }
    //            map[nums[i]] = i;
    //        }
    //        return new int[] { 0 };
    //    }
    //}
    #endregion

    #region 
    //public class Solution1611
    //{
    //    public int MinimumOneBitOperations(int n) => (n == 0) ? 0 : n ^ MinimumOneBitOperations(n >> 1);
    //}
    #endregion

    #region 
    //public class Solution1662
    //{
    //    public bool ArrayStringsAreEqual(string[] word1, string[] word2) => string.Concat(word1) == string.Concat(word2);
    //}
    //public class Solution1
    //{
    //    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    //    {
    //        return string.Concat(word1).Equals(string.Concat(word2));
    //    }
    //}
    #endregion

    #region 
    //public class Solution1160
    //{
    //    public int CountCharacters(string[] words, string chars)
    //    {
    //        int result = 0;
    //        string temp = chars;
    //        foreach (string word in words)
    //        {
    //            int count = 0;
    //            foreach (char c in word)
    //            {
    //                if (temp.Contains(c))
    //                {
    //                    count++;
    //                    temp = temp.Remove(temp.IndexOf(c), 1);
    //                }
    //                else
    //                    break;
    //            }
    //            if (count == word.Length)
    //                result += word.Length;
    //            temp = chars;
    //        }

    //        return result;
    //    }
    //}
    #endregion

    #region 
    //public class Solution1266
    //{
    //    public int MinTimeToVisitAllPoints(int[][] points)
    //    {
    //        int time = 0;
    //        for (int i = 0; i < points.Length - 1; ++i)
    //        {
    //            int deltaX = Math.Abs(points[i][0] - points[i + 1][0]);
    //            int deltaY = Math.Abs(points[i][1] - points[i + 1][1]);
    //            time += Math.Max(deltaX, deltaY);
    //        }
    //        return time;
    //    }
    //}
    #endregion

    #region 
    //public class Solution1688
    //{
    //    public string LargestGoodInteger(string num)
    //    {
    //        int target = -1;
    //        for (int i = 0; i < num.Length - 2; ++i)
    //            if (num[i] == num[i + 1] && num[i + 1] == num[i + 2])
    //                if (int.Parse(num.Substring(i, 3)) > target)
    //                    target = int.Parse(num.Substring(i, 3));
    //        return (target != -1) ? ((target == 0) ? target + "00" : target.ToString()) : "";
    //    }
    //}
    //public class Solution
    //{
    //    public string LargestGoodInteger(string num)
    //    {
    //        int target = -1;
    //        for (int i = 0; i < num.Length - 2; ++i)
    //        {
    //            if (num[i] == num[i + 1] && num[i + 1] == num[i + 2])
    //            {
    //                int current = int.Parse(num.Substring(i, 3));
    //                if (current > target)
    //                    target = current;
    //            }
    //        }
    //        return (target != -1) ? ((target == 0) ? target + "00" : target.ToString()) : "";

    //    }
    //}
    #endregion

    #region
    //public class Solution
    //{
    //public int NumberOfMatches(int n) => (n % 2 == 1) ? (((n - 1) / 2 + NumberOfMatches((n - 1) / 2 + 1))) : ((n > 2) ? n / 2 + NumberOfMatches(n / 2) : 1);
    //}
    #endregion

    #region 
    //public class Solution1716
    //{
    //    public int TotalMoney(int n) => Enumerable.Range(1, n).Select((val, index) => (val % 7 == 0 ? 7 : val % 7) + index/7).Sum();
    //}
    #endregion

    #region 
    //public class Solution1903
    //{
    //    public string LargestOddNumber(string num) => num[..(1 + num.LastIndexOfAny(new[] { '1', '3', '5', '7', '9' }))];
    //}
    #endregion

    #region 
    //Definition for a binary tree node.
    //public class TreeNode
    //{
    //    public int val;
    //    public TreeNode left;
    //    public TreeNode right;
    //    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    //    {
    //        this.val = val;
    //        this.left = left;
    //        this.right = right;
    //    }
    //}
    //public class Solution606
    //{
    //    public string Tree2str(TreeNode root)
    //    {
    //        if (root == null)
    //            return "";

    //        string result = root.val.ToString();

    //        if (root.left != null || root.right != null)
    //            result += "(" + Tree2str(root.left) + ")";

    //        if (root.right != null)
    //            result += "(" + Tree2str(root.right) + ")";
    //        return result;
    //    }
    //}
    #endregion

    #region 
    ////Definition for a binary tree node.
    //public class TreeNode
    //{
    //    public int val;
    //    public TreeNode left;
    //    public TreeNode right;
    //    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    //    {
    //        this.val = val;
    //        this.left = left;
    //        this.right = right;
    //    }
    //}

    //public class Solution94
    //{
    //    public IList<int> InorderTraversal(TreeNode root)
    //    {
    //        List<int> result = new();
    //        Stack<TreeNode> stack = new();

    //        var currentnode = root;
    //        while (currentnode != null || stack.Count != 0)
    //        {
    //            if (currentnode != null)
    //            {
    //                stack.Push(currentnode);
    //                currentnode = currentnode.left;
    //            }
    //            else
    //            {
    //                currentnode = stack.Pop();
    //                result.Add(currentnode.val);
    //                currentnode = currentnode.right;
    //            }
    //        }

    //        return result;
    //    }
    //}
    #endregion

    #region 
    //public class Solution867
    //{
    //    public int[][] Transpose(int[][] matrix)
    //    {
    //        int[][] results = new int[matrix[0].Length][];

    //        for (int i = 0; i < matrix[0].Length; i++)
    //            results[i] = new int[matrix.Length];

    //        for (int row = 0; row < matrix.Length; row++)
    //            for (int column = 0; column < matrix[0].Length; column++)
    //                results[column][row] = matrix[row][column];

    //        return results;
    //    }
    //}
    #endregion

    #region 
    //public class Solution1464
    //{
    //    public int FindSpecialInteger(int[] arr)
    //    {
    //        int count = arr.Length / 4;
    //        int current = arr[0];
    //        int currentCount = 1;

    //        for (int i = 1; i < arr.Length; i++)
    //        {
    //            if (arr[i] != current)
    //            {
    //                current = arr[i];
    //                currentCount = 1;
    //            }
    //            else
    //            {
    //                currentCount++;
    //                if (currentCount > count)
    //                    return current;
    //            }
    //        }
    //        return current;
    //    }

    //}
    #endregion

    #region 
    //public class Solution1582
    //{
    //    public int NumSpecial(int[][] mat)
    //    {
    //        int[] rSum = new int[mat.Length];
    //        int[] cSum = new int[mat[0].Length];
    //        for (int i = 0; i < mat.Length; i++)
    //        {
    //            for (int j = 0; j < mat[0].Length; j++)
    //            {
    //                rSum[i] += mat[i][j];
    //                cSum[j] += mat[i][j];
    //            }
    //        }



    //        int res = 0;
    //        for (int i = 0; i < mat.Length; i++)
    //        {
    //            if (rSum[i] == 1)
    //                for (int j = 0; j < mat[0].Length; j++)
    //                {
    //                    if (mat[i][j] == 1 && cSum[j] == 1)
    //                        res++;
    //                }
    //        }

    //        return res;
    //    }
    //}
    #endregion

    #region 
    //public class Solution2482
    //{
    //    public int[][] OnesMinusZeros(int[][] grid)
    //    {
    //        int m = grid.Length;
    //        int n = grid[0].Length;
    //        int[][] diff = new int[m][];

    //        int[] onesRow = new int[m];
    //        int[] zerosRow = new int[m];
    //        int[] onesCol = new int[n];
    //        int[] zerosCol = new int[n];

    //        for (int i = 0; i < m; ++i)
    //        {
    //            diff[i] = new int[n];
    //            for (int j = 0; j < n; ++j)
    //            {
    //                if (grid[i][j] != 1)
    //                {
    //                    zerosRow[i]++;
    //                    zerosCol[j]++;
    //                }
    //                else
    //                {
    //                    onesRow[i]++;
    //                    onesCol[j]++;
    //                }
    //            }
    //        }
    //        for (int i = 0; i < m; ++i)
    //        {
    //            for (int j = 0; j < n; ++j)
    //            {
    //                diff[i][j] = onesRow[i] + onesCol[j] - zerosRow[i] - zerosCol[j];
    //            }
    //        }
    //        return diff;
    //    }
    //}
    #endregion


}
