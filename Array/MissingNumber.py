#268. Missing Number

class Solution:
    def missingNumber(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        s = sum(nums)
        l = len(nums)
        return (int)(l*(l+1) / 2) - s