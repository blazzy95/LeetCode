using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 637. Average of Levels in Binary Tree
/// </summary>

namespace LeetCode
{
	class AverageOfLevels
    {
		public static IList<double> AverageofLevels(TreeNode root)
        {
            List<double> result = new List<double>();
            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);
            while (queue.Count!=0)
            {
                long sumCurrentLevel = 0;
                int countCurrentLevel = queue.Count;
                for (int i = 0; i < countCurrentLevel; i++)
                {
                    TreeNode current = queue.Dequeue();
                    sumCurrentLevel += current.val;
                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }
                    if (current.right != null)  
                    {
                        queue.Enqueue(current.right);
                    }
                }
                if (countCurrentLevel != 0)
                {
                    result.Add((double)sumCurrentLevel / countCurrentLevel);
                }
            }

            return result;
        }
	}
}