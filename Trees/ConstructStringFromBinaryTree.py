# 606. Construct String from Binary Tree

class TreeNode(object):
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Solution(object):
    def tree2str(self, t):
        """
        :type t: TreeNode
        :rtype: str
        """
        if not t:
            return ""
        
        if not t.left and not t.right:
            return str(t.val)
        
        if t.left and not t.right:
            return str(t.val) + "(" + self.tree2str(t.left) + ")"
        return str(t.val) + "(" + self.tree2str(t.left) + ")" + "(" +self.tree2str(t.right) + ")"


"""
if not t:
            return ""
        
        self.ans = ""
        self.ans = self.convert(t)
        return self.ans[1:len(self.ans)-1]
        
    def convert(self,t):
        if t is None:
            return
        
        self.ans += "("+str(t.val)

        if not t.left and t.right:
            self.ans += "()"

        if t.left:
            self.convert(t.left)
        if t.right:
            self.convert(t.right)
            self.ans += ")" 
        else:
            self.ans += ")"
        
        return self.ans
"""