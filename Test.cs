#region 1480
//public class Solution
//{
//    public int[] RunningSum(int[] nums)
//    {
//        int[] runningSum = new int[nums.Length];

//        for (int i = nums.Length; i > 0; i--)
//        {
//            for (int j = 0; j < i; j++)
//            {
//                runningSum[i - 1] += nums[j];
//            }
//        }
//        return runningSum;
//    }
//}
#endregion

#region 205
//public class Solution
//{
//    public int PivotIndex(int[] nums)
//    {
//        int totalSum = 0;
//        for (int i = 0; i < nums.Length; i++) totalSum += nums[i];

//        int leftSum = 0;
//        for (int i = 0; i < nums.Length; i++)
//        {
//            if (totalSum - nums[i] == leftSum*2) return i;
//            leftSum += nums[i];
//        }
//        return -1;
//    }
//}
#endregion

#region
//public class Solution
//{
//    public int FindKthPositive(int[] arr, int k)
//    {
//        int[] missingint = new int[1000];
//
//        if (arr[0] != 1)
//            missingint[0] = 1;
//
//        for (int i = 0; i < arr.Length;)
//        {
//            if (arr[i] + 1 != arr[i + 1])
//            {
//                missingint[i] = arr[i] + 1;
//                for (int j = 0; j < arr[i + 1] - arr[i]; j++)
//                {
//                    missingint[i + 1 + j] += missingint[i + j];
//                }
//            }
//        }
//
//        return missingint[k];
//    }
//}
#endregion

#region 1768
//public class Solution
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

#region 1672
//public class Solution
//{
//    public int MaximumWealth(int[][] accounts)
//    {
//        int RichestCustomerWealth = 0;
//        for (int i = 0; i < accounts.Length; i++)
//        {
//            int Wealth = 0;
//            Array.ForEach(accounts[i], value => Wealth += value);

//            if (Wealth > RichestCustomerWealth)
//                RichestCustomerWealth = Wealth;
//        }
//        return RichestCustomerWealth;
//    }
//}
#endregion

#region 412
//public class Solution
//{
//    //Given an integer n, return a string array answer(1-indexed) where:

//    //answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
//    //answer[i] == "Fizz" if i is divisible by 3.
//    //answer[i] == "Buzz" if i is divisible by 5.
//    //answer[i] == i(as a string) if none of the above conditions are true.

//    public IList<string> FizzBuzz(int n)
//    {
//        var list = new List<string>(n);
//        for (int i = 1; i <= n; i++)
//        {
//            string item = (i % 3 == 0, i % 5 == 0) switch
//            {
//                (true, true) => "FizzBuzz",
//                (true, false) => "Fizz",
//                (false, true) => "Buzz",
//                (false, false) => i.ToString(),
//            };

//            list.Add(item);
//        }

//        return list;
//    }

//}
#endregion

#region 876
//public class Solution
//{
//    //Definition for singly-linked list.
//    public class ListNode
//    {
//        public int val;
//        public ListNode next;
//        public ListNode(int val = 0, ListNode next = null)
//        {
//            this.val = val;
//            this.next = next;
//        }
//    }

//    public ListNode? MiddleNode(ListNode head)
//    {
//        ListNode currentNode1 = head;
//        int count1 = 0;
//        while (currentNode1 != null)
//        {
//            currentNode1 = currentNode1.next;
//            count1++;
//        }

//        ListNode currentNode2 = head;
//        int count2 = 0;
//        while (true)
//        {
//            if (count2 == count1 / 2)
//                return currentNode2;

//            currentNode2 = currentNode2.next;
//            count2++;
//        }
//    }
//}
#endregion

#region 383
//public class Solution
//{
//    public bool CanConstruct(string ransomNote, string magazine)
//    {
//        List<char> list = new List<char>(magazine);

//        for (int i = 0; i < ransomNote.Length; i++)
//        {
//            if (!list.Remove(ransomNote[i]))
//                return false;
//        }
//        return true;
//    }
//}
#endregion

#region 1
//public class Solution
//{
//    public int[] TwoSum(int[] nums, int target)
//    {
//        for (int i = 0; i < nums.Length; i++)
//        {
//            for (int j = i + 1; j < nums.Length; j++)
//            {
//                if (nums[i] + nums[j] == target)
//                    return new int[] { i, j };
//            }
//        }

//        throw new ArgumentException("No solution found");
//    }
//}
#endregion

#region Binary Tree Paths
//using System.Linq;
//using System.Reflection.Metadata;

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

//public class Solution
//{
//    //public IList<string> BinaryTreePaths(TreeNode root)
//    //{
//    //    List<string> paths = new List<string>();
//    //    string s = "";

//    //    FindPath(root, s);

//    //    void FindPath(TreeNode root, string s1)
//    //    {
//    //        if (root != null)
//    //        {
//    //            if (root.left == null && root.right == null)
//    //            {
//    //                s1 = s1 + root.val;
//    //                paths.Add(s1);
//    //            }
//    //            else
//    //            {
//    //                s1 = s1 + root.val + "->";
//    //                FindPath(root.left, s1);
//    //                FindPath(root.right, s1);
//    //            }
//    //        }
//    //    }

//    //    return paths;
//    //}

//    public IList<string> BinaryTreePaths(TreeNode root)
//    {
//        IList<string> leftPath = new List<string>();
//        IList<string> rightPath = new List<string>();

//        if (root.left != null)
//        {
//            leftPath = BinaryTreePaths(root.left);
//            for (int i = 0; i < leftPath.Count; i++)
//                leftPath[i] = root.val + "->" + leftPath[i];
//        }
//        else if (root.right == null)
//        {
//            leftPath.Add(root.val.ToString());
//            return leftPath;
//        }

//        if (root.right != null)
//        {
//            rightPath = BinaryTreePaths(root.right);
//            for (int i = 0; i < rightPath.Count; i++)
//                rightPath[i] = root.val + "->" + rightPath[i];
//        }
//        else if (root.left == null)
//        {
//            rightPath.Add(root.val.ToString());
//            return rightPath;
//        }

//        return leftPath.Concat(rightPath).ToList();
//    }
//}
#endregion

#region 228
//public class Solution
//{
//    public IList<string> SummaryRanges(int[] nums)
//    {
//        if (nums == null || nums.Length == 0)
//            return new List<string>();

//        if (nums.Length == 1)
//            return new List<string>() { nums[0].ToString() };

//        var result = new List<string>();

//        int start = nums[0];
//        int previous = start;
//        for (int i = 1; i < nums.Length; ++i)
//        {
//            int current = nums[i];
//            if (current != previous + 1)
//            {
//                if (start == previous)
//                    result.Add(previous.ToString());
//                else
//                    result.Add(start + "->" + previous);

//                if (nums.Length - 1 == i)
//                    result.Add(current.ToString());

//                start = current;
//            }
//            else if (nums.Length - 1 == i)
//                result.Add(start + "->" + current.ToString());

//            previous = current;
//        }

//        return result;
//    }
//}
#endregion

#region 2849
//public class Solution
//{
//    public bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t)
//    {
//        if (sx == fx && sy == fy)
//            return t > 1 || t == 0;

//        return t >= Math.Max(Math.Abs(fx - sx), Math.Abs(fy - sy));
//    }
//}
#endregion

#region 2352
//using System.Collections.Generic;
//public class Solution
//{
//    public int EqualPairs(int[][] grid)
//    {
//        int count = 0;
//        int[] cols = new int[grid.Length];
//        for (int i = 0; i < grid.Length; i++)
//        {
//            for (int j = 0; j < grid[i].Length; j++)
//                cols[j] = grid[j][i];
//            for (int k = 0; k < cols.Length; k++)
//                if (cols.SequenceEqual(grid[k]))
//                    count++;
//        }
//        return count;
//    }
//}
//#endregion
#endregion

#region 1356
//public class Solution
//{
//    public int[] SortByBits(int[] arr)
//    {
//        Array.Sort(arr);
//        return arr.OrderBy(i => Convert.ToString(i, 2).Count(digit => digit == '1')).ToArray();
//    }
//}
#endregion

#region 9
//public class Solution
//{
//    public bool IsPalindrome(int x) => x.ToString().Equals(new string(x.ToString().Reverse().ToArray()));

//}
#endregion

#region 141
//public class ListNode
//{
//    public int val;
//    public ListNode next;
//    public ListNode(int x)
//    {
//        val = x;
//        next = null;
//    }
//}

//public class Solution
//{
//    public bool HasCycle(ListNode head)
//    {
//        HashSet<ListNode> visited = new();
//        ListNode current_node = head;
//        while (current_node != null)
//        {
//            if (visited.Contains(current_node))
//                return true;
//            visited.Add(current_node);
//            current_node = current_node.next;
//        }
//        return false;
//    }
//}
#endregion

#region 1759
//public class Solution
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

#region 1685
//public class Solution
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

#region 1727
//public class Solution
//{
//    public int HammingWeight(uint n) => Convert.ToString(n, 2).Count((x) => x == '1');

//}
#endregion

#region 815. Bus Routes
//public class Solution
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
public class Test
{
    public static void Main(string[] args)
    {
    }
}