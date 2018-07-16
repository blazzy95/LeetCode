#144. Binary Tree Preorder Traversal

class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Solution:
    def preorderTraversal(self, root):
        """
        :type root: TreeNode
        :rtype: List[int]
        """
        self.res = []
        self.getpreorder(root)
        return self.res

    def getpreorder(self, root):

        if root is None:
            return
        
        self.res.append(root.val)
        self.getpreorder(root.left)
        self.getpreorder(root.right)
        