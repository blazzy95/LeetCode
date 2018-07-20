# 35. Search Insert Position

class Solution:
    def searchInsert(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: int
        """
        if target in nums:
            return nums.index(target)
        for i in nums:
            if target < i:
                return nums.index(i)
        return len(nums)