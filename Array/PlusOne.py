#66. Plus One

class Solution(object):
    def plusOne(self, digits):
        """
        :type digits: List[int]
        :rtype: List[int]
        """
        i = len(digits) - 1
        while i > -1:
            if digits[i] is not 9:
                digits[i] += 1
                break
            else:
                digits[i] = 0
                if i is 0:
                    digits.insert(0,1)
            i-=1
        return digits