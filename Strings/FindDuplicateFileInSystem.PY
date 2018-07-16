#609. Find Duplicate File in System

class Solution(object):
    def findDuplicate(self, paths):
        """
        :type paths: List[str]
        :rtype: List[List[str]]
        """
        ret = []
        hm = dict()
        self.buildHashMap(paths, hm)
        for k , v in hm.items():
            if len(v) >1:
                ret.append(v)

        return ret
        
    def buildHashMap(self, paths, hm):
        for s in paths:
            tmpList = s.split()
            folder = tmpList[0]
            for i in range(1, len(tmpList)):
                fileName, fileContent = tmpList[i].split('(')
                fileContent = fileContent[:len(fileContent)-1]
                group = hm.setdefault(fileContent, [])
                group.append(folder + '/' + fileName)