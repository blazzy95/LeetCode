#226. Invert Binary Tree

class TreeNode(object):
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Solution(object):
    def invertTree(self, root):
        """
        :type root: TreeNode
        :rtype: TreeNode
        """
        if root is None:
            return root
        temp = root.left
        root.left = root.right
        root.right = temp

        if root.right is not None:
            self.invertTree(root.right)
        elif root.left is not None:
            self.invertTree(root.left)

        return root