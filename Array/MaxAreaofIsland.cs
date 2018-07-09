using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 695. Max Area of Island
/// </summary>


namespace leetcodeLocal
{
    class MaxAreaofIsland
    {
        public static int MaxAreaOfIsland(int[,] grid)
        {
            int area = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i,j] != 0)
                    {
                        area = Math.Max(area, CalculateArea(grid, i, j));
                    }
                }
            }
            return area;
        }

        private static int CalculateArea(int[,] grid, int i, int j)
        {
            if (i >= 0 && i < grid.GetLength(0) && j >= 0 && j < grid.GetLength(1) && grid[i,j] != 0)
            {
                grid[i,j] = 0;
                return 1 + CalculateArea(grid, i + 1, j) + CalculateArea(grid, i - 1, j) + CalculateArea(grid, i, j + 1) + CalculateArea(grid, i, j - 1);
            }
            return 0;
        }
    }
}
