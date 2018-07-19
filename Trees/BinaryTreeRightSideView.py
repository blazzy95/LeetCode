# 199. Binary Tree Right Side View
from collections import deque
# Definition for a binary tree node.
class TreeNode(object):
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Solution(object):
    def rightSideView(self, root):
        """
        :type root: TreeNode
        :rtype: List[int]
        """
        res = []
        if root is None:
            return res

        queue = deque()
        queue.append(root)
        while len(queue) is not 0:
            size = len(queue)
            for i in range(0,size):
                node = queue.popleft()
                if i is size - 1:
                    res.append(node.val)
                if node.left:
                    queue.append(node.left)
                if node.right:
                    queue.append(node.right)
            
        return res