using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
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
}
