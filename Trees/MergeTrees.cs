using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 617. Merge Two Binary Trees
/// </summary>

namespace BinaryTree
{
    /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
    public class Solution
    {
        public static TreeNode Mergetrees(TreeNode t1, TreeNode t2)
        {
            if (t1 != null && t2 != null)
            {
                t1.left = MergeTrees(t1.left, t2.left);
                t1.right = MergeTrees(t1.right, t2.right);
                t1.val += t2.val;
                return t1;
            }
            return t1 == null ? t2 : t1;
        }
    }
}
