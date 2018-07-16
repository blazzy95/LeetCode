#94. Binary Tree Inorder Traversal

# Definition for a binary tree node.
class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Solution:
    def inorderTraversal(self, root):
        """
        :type root: TreeNode
        :rtype: List[int]
        """
        self.res = []
        self.getInOrder(root)
        return self.res

    def getInOrder(self, root):

        if root is None:
            return
        self.getInOrder(root.left)
        self.res.append(root.val)
        self.getInOrder(root.right)