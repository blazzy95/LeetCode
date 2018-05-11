using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddTwoSum
{
    class AddTwoNumbers
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode AddTwoNumber(ListNode l1, ListNode l2)
        {
            ListNode ptr1 = l1;
            ListNode ptr2 = l2;
            ListNode l3 = new ListNode(0);
            ListNode ptr3 = l3;
            int carry = 0;

            while (ptr1 != null || ptr2 != null)
            {
                if (ptr1 != null)
                {
                    carry += ptr1.val;
                    ptr1 = ptr1.next;
                }
                if (ptr2 != null)
                {
                    carry += ptr2.val;
                    ptr2 = ptr2.next;
                }
                ptr3.next = new ListNode(carry % 10);
                ptr3 = ptr3.next;
                carry /= 10;
            }
            if (carry == 1)
                ptr3.next = new ListNode(1);

            return l3.next;

        }
    }
}
