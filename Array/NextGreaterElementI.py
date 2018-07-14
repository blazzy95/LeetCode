#496. Next Greater Element I

class Solution:
    def nextGreaterElement(self, nums1, nums2):
        """
        :type nums1: List[int]
        :type nums2: List[int]
        :rtype: List[int]
        """
        indexdict = {}
        res = []

        for i in range (len(nums2)):
            indexdict[nums2[i]] = i

        flag = True
        
        for i in range (len(nums1)):
            flag = True
            for j in range(indexdict[nums1[i]]+1,len(nums2)):
                if nums2[j] > nums1[i]:
                    res.append(nums2[j])
                    flag = False
                    break
            if flag:
                res.append(-1)
        return res                



list1 = [4,1,2]
list2 = [1,3,4,2]
res = Solution().nextGreaterElement(list1, list2)
print(res)