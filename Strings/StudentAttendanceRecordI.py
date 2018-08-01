# 551. Student Attendance Record I

class Solution:
    def checkRecord(self, s):
        """
        :type s: str
        :rtype: bool
        """
        a = l = 0
        for i in range(0,len(s)):
            if s[i]=='A':
                a+=1
            if s[i]=='L':
                l+=1
            else: 
                l=0
            if a>=2 or l>2: 
                return False
        
        return True