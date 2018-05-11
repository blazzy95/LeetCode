using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeTwoSortedLists
{
    class MergeTwoSortedLists
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode list = new ListNode(0);
            ListNode node = list;
            while (l1 != null || l2 != null)
            {
                if (l1 != null && l2 != null)
                {
                    if (l1.val < l2.val)
                    {
                        node.next = l1;
                        l1 = l1.next;
                    }
                    else
                    {
                        node.next = l2;
                        l2 = l2.next;
                    }
                    node = node.next;
                }
                else if (l1 == null)
                {
                    node.next = l2;
                    break;
                }
                else if (l2 == null)
                {
                    node.next = l1;
                    break;
                }

            }
            return list.next;
        }
    }
}
