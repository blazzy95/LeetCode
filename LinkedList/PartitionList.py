#86. Partition List
#Definition for singly-linked list.
class ListNode:
    def __init__(self, x):
        self.val = x
        self.next = None

class Solution:
    def partition(self, head, x):
        """
        :type head: ListNode
        :type x: int
        :rtype: ListNode
        """
        startL = left = ListNode(-99)
        startR = right = ListNode(-99)

        while head is not None:
            if head.val < x:
                left.next = head
                left = left.next
            else:
                right.next = head
                right = right.next
            head = head.next

        left.next = startR.next
        right.next = None
        return startL.next
