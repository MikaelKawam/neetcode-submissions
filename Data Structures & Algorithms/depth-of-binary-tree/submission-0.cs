/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int MaxDepth(TreeNode root)
    {
        int Count(TreeNode root, int count)
        {
            if (root == null) return count;
            count++;

            return Math.Max(Count(root.right, count), Count(root.left, count));
        }

        return Count(root, 0);
    }
}
