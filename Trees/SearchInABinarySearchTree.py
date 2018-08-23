#700. Search in a Binary Search Tree

class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Solution:
    def searchBST(self, root, val):
        """
        :type root: TreeNode
        :type val: int
        :rtype: TreeNode
        """
        if root is None:
            return None
        if val == root.val:
            return root

        if val > root.val:
            return self.searchBST(root.right,val)
        elif val < root.val:
            return self.searchBST(root.left,val)