# 107. Binary Tree Level Order Traversal II

# Definition for a binary tree node.
class TreeNode(object):
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Solution(object):
    def levelOrderBottom(self, root):
        """
        :type root: TreeNode
        :rtype: List[List[int]]
        """
        if root is None:
            return []
        res = []
        nodes = []
        from collections import deque
        queue = deque()
        queue.append(root)

        while len(queue) is not 0:
            nodes = []
            size = len(queue)
            for i in range(0,size):
                node = queue.popleft()
                nodes.append(node.val)
                if node.left:
                    queue.append(node.left)
                if node.right:
                    queue.append(node.right)
            res.append(nodes)
        return res[::-1]