# 448. Find All Numbers Disappeared in an Array

class Solution:
    def findDisappearedNumbers(self, nums):
        """
        :type nums: List[int]
        :rtype: List[int]
        """
        result = []
        numsset = set(nums)
        for i in range(1,len(nums)+1):
            if i not in numsset:
                result.append(i)
        return result