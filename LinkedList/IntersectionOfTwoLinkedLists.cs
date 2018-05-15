using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//160. Intersection of Two Linked Lists

namespace IntersectionOfTwoLinkedLists
{
    class IntersectionOfTwoLinkedLists
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

            public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
            {
                int len1 = 0, len2 = 0;
                ListNode l1 = headA, l2 = headB;
                int i = 0;

                //count length
                while (l1 != null)
                {
                    len1++;
                    l1 = l1.next;
                }
                while (l2 != null)
                {
                    len2++;
                    l2 = l2.next;
                }

                //calculate offset
                int offset = Math.Abs(len1 - len2);
                l1 = headA;
                l2 = headB;

                //adjust the offset
                if (len1 > len2)
                {
                    while (i < offset)
                    {
                        l1 = l1.next;
                        i++;
                    }
                }
                else
                {
                    while (i < offset)
                    {
                        l2 = l2.next;
                        i++;
                    }
                }

            //compare nodes
            while (l1 != null && l2 != null)
            {
                if (l1.val == l2.val)
                    return l2;
                else
                {
                    l1 = l1.next;
                    l2 = l2.next;
                }
            }

            return null;

        }
        
    }
}
