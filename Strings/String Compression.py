# 443. String Compression

class Solution:
    def compress(self, chars):
        """
        :type chars: List[str]
        :rtype: int
        """
        n = 0
        curr = chars[0]
        count = 0
        for i in range(len(chars)):
            if chars[i] != curr:
                chars[n] = curr
                n += 1
                if count > 1:
                    for digit in str(count):
                        chars[n] = digit
                        n += 1
                curr = chars[i]
                count = 1
            else:
                count += 1
                
        chars[n] = curr
        n += 1
        if count > 1:
            for digit in str(count):
                chars[n] = digit
                n += 1
        
        return n