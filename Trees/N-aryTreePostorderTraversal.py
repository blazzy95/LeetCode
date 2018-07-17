#590. N-ary Tree Postorder Traversal

# Definition for a Node.
class Node(object):
    def __init__(self, val, children):
        self.val = val
        self.children = children

class Solution(object):
    def postorder(self, root):
        """
        :type root: Node
        :rtype: List[int]
        """

        res = []
        if root is None:
            return root

        for child in root.children:
            res.extend(self.postorder(child))

        res.append(root.val)
        return res