# 495. Teemo Attacking

class Solution:
    def findPoisonedDuration(self, timeSeries, duration):
        """
        :type timeSeries: List[int]
        :type duration: int
        :rtype: int
        """

        if len(timeSeries) == 0:
            return 0
        res = 0
        for i in range(1,len(timeSeries)):
            d = timeSeries[i] - timeSeries[i - 1]
            res += d if (d < duration) else duration
        return res + duration