using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
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
}
