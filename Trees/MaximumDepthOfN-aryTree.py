# 559. Maximum Depth of N-ary Tree

class Node(object):
    def __init__(self, val, children):
        self.val = val
        self.children = children

class Solution(object): 
    def maxDepth(self, root):
        """
        :type root: Node
        :rtype: int
        """

        if not root:
            return 0

        if not root.children:
            return 1
        
        d = 1 + max(self.maxDepth(n) for n in root.children)

        return d
            
        
                    
c1 = [Node(2,[Node(3,[Node(9,None)])]),Node(3,None),Node(4,None)]
first = Node(1,c1)

res = Solution().maxDepth(first)
print(res)
            

