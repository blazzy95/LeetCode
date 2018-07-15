#513. Find Bottom Left Tree Value

from collections import deque
# Definition for a binary tree node.
class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Solution:
    def findBottomLeftValue(self, root):
        """
        :type root: TreeNode
        :rtype: int
        """
        d = deque()
        d.append(root)
        leftMost = root
        while len(d)is not 0: 
            for i in range (0,len(d)):
                curr = d.popleft()
                if i is 0:
                    leftMost = curr
                if curr.left is not None:
                    d.append(curr.left)
                if curr.right is not None:
                    d.append(curr.right)
        return leftMost.val


                
