#203. Remove Linked List Elements

class ListNode:
    def __init__(self, x):
        self.val = x
        self.next = None

class Solution:
    def removeElements(self, head, val):
        """
        :type head: ListNode
        :type val: int
        :rtype: ListNode
        """

        while head and head.val == val:
            head = head.next
        if not head:
            return head
            
        node = head
        next_node = node.next
        
        while next_node:
            if next_node.val == val:
                node.next = next_node.next
                next_node = node.next
            else:
                next_node = next_node.next
                node = node.next
        return head

