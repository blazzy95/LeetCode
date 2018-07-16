# 145. Binary Tree Postorder Traversal

# Definition for a binary tree node.
class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Solution:
    def postorderTraversal(self, root):
        """
        :type root: TreeNode
        :rtype: List[int]
        """
        self.res = []
        self.getpostorder(root)
        return self.res

    def getpostorder(self, root):

        if root is None:
            return
        self.getpostorder(root.left)
        self.getpostorder(root.right)
        self.res.append(root.val)