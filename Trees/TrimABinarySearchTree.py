#669. Trim a Binary Search Tree

class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Solution:
    def trimBST(self, root, L, R):
        """
        :type root: TreeNode
        :type L: int
        :type R: int
        :rtype: TreeNode
        """

        if not root:
            return None
        
        if root.val < L:
            return self.trimBST(root.right,L,R)
        if root.val > R:
            return self.trimBST(root.left,L,R)
        root.left, root.right = self.trimBST(root.left,L,R) , self.trimBST(root.right,L,R)
        return root


tree = TreeNode(1)
tree.left = TreeNode(0)
tree.right = TreeNode(2)

res = Solution().trimBST(tree,1,2)
print(res)