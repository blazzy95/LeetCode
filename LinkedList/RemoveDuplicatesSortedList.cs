using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// 83. Remove Duplicates from Sorted List
/// </summary>

namespace RemoveDuplicatesFromSortedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    class Class1
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode node = head;

            while (node != null && node.next != null)
            {
                if (node.val == node.next.val)
                {
                    node.next = node.next.next;
                }
                else
                {
                    node = node.next;
                }
            }
            return head;


        }
    }
}
