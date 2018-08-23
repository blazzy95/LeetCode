#888. Fair Candy Swap

class Solution:
    def fairCandySwap(self, A, B):
        """
        :type A: List[int]
        :type B: List[int]
        :rtype: List[int]
        """
        diff = (sum(A)-sum(B))//2
        setA = set(A)
        for b in set(B):
            if diff+b in setA:
                return [diff+b, b]
        return []

        

A = [1,2,5]
B = [2,4]

val = Solution().fairCandySwap(A,B)
print(val)