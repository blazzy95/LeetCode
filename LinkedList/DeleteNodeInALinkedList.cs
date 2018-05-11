using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// 237. Delete Node in a Linked List
/// </summary>

namespace DeleteNodeInALinkedList
{
    class DeleteNodeInALinkedList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public class Solution
        {
            public void DeleteNode(ListNode node)
            {
                node.val = node.next.val;
                node.next = node.next.next;
            }
        }
    }
}
