#Definition for a binary tree node.
class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Solution:
    def pruneTree(self, root):
        """
        :type root: TreeNode
        :rtype: TreeNode
        """
        if root is None:
            return root
        
        if root.left is not None:
            root.left = self.pruneTree(root.left)

        if root.right is not None:
            root.right = self.pruneTree(root.right)

        if root.val is 1 or root.left or root.right:
            return root
        else:
            return None



