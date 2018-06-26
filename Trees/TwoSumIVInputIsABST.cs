using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 653. Two Sum IV - Input is a BST
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
        public bool FindTarget(TreeNode root, int k)
        {
            HashSet<int> set = new HashSet<int>();
            Stack<TreeNode> nodes = new Stack<TreeNode>();

            while (nodes.Count != 0 || root != null)
            {
                if (root != null)
                {
                    if (set.Contains(root.val))
                        return true;
                    set.Add(k - root.val);
                    nodes.Push(root);
                    root = root.left;
                }
                else
                {
                    root = nodes.Pop().right;
                }
            }

            return false;
        }
    }
}
