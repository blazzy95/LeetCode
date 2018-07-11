#19. Remove Nth Node From End of List

# Definition for singly-linked list.
class ListNode:
    def __init__(self, x):
        self.val = x
        self.next = None

class Solution:
    def removeNthFromEnd(self, head, n):
        """
        :type head: ListNode
        :type n: int
        :rtype: ListNode
        """
        node = ListNode(-1)
        node.next = head
        fast = node
        slow = node
        i = 0

        while i<n:
            fast = fast.next
            i +=1

        while fast.next is not None:
            slow = slow.next
            fast = fast.next

        slow.next = slow.next.next
        
        return node.next





        
        