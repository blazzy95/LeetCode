#328. Odd Even Linked List

# Definition for singly-linked list.
class ListNode:
    def __init__(self, x):
        self.val = x
        self.next = None

class Solution:
    def oddEvenList(self, head):
        """
        :type head: ListNode
        :rtype: ListNode
        """

        if head is None or head.next is None:
            return head

        if head is not None:
            slow = head
            fast = head.next
            ptr = fast

        while fast is not None and fast.next is not None:
            slow.next = slow.next.next
            fast.next = fast.next.next
            slow = slow.next
            fast = fast.next
        
        slow.next = ptr

        return head