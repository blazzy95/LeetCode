#872. Leaf-Similar Trees

# Definition for a binary tree node.
class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Solution:
    def leafSimilar(self, root1, root2):
        """
        :type root1: TreeNode
        :type root2: TreeNode
        :rtype: bool
        """
        self.leaf1 = []
        self.leaf2 = []
        self.leafCollector(root1,self.leaf1)
        self.leafCollector(root2,self.leaf2)

        return self.leaf1 == self.leaf2
    
    def leafCollector(self,node, leafs):
        if node is None:
            return
        if node.left is None and node.right is None:
            leafs.append(node.val)
            return
        if node.left:
            self.leafCollector(node.left,leafs)
        if node.right:
            self.leafCollector(node.right,leafs)