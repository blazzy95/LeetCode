# 404. Sum of Left Leaves

# Definition for a binary tree node.
class TreeNode(object):
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Solution(object):
    def sumOfLeftLeaves(self, root):
        """
        :type root: TreeNode
        :rtype: int
        """
        self.sum = 0
        self.calculatesum(root)
        return self.sum

    def calculatesum(self,root):
        if root is None:
            return root

        if root.left is not None:
            if root.left.left is None and root.left.right is None:
                self.sum = self.sum + root.left.val
        self.calculatesum(root.left)
        self.calculatesum(root.right)