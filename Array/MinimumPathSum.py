# 64. Minimum Path Sum

class Solution:
    def minPathSum(self, grid):
        """
        :type grid: List[List[int]]
        :rtype: int
        """

        # boundry conditions
        for i in range(1,len(grid[0])):
            grid[0][i] = grid[0][i-1] + grid[0][i]
        
        for i in range(1,len(grid)):
            grid[i][0] = grid[i-1][0] + grid[i][0]

        # dp
        for j in range(1, len(grid)):
            for i in range(1,len(grid[j])):
                grid[j][i] = min(grid[j][i]+grid[j][i-1],grid[j][i]+grid[j-1][i])

        return grid[len(grid)-1][len(grid[len(grid)-1])-1]