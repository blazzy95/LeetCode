#104. Maximum Depth of Binary Tree

# Definition for a binary tree node.
class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Solution:
    def maxDepth(self, root):
        """
        :type root: TreeNode
        :rtype: int
        """

        if root is None:
            return 0
        
        else:
            maxD = max(self.maxDepth(root.left),self.maxDepth(root.right))
            return 1 + maxD
        