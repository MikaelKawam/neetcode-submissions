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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        var isCurrP = root.val == p.val;
        var isCurrQ = root.val == q.val;

        if (p.val > root.val && q.val > root.val)
        {
            var isPdescent = isCurrP || root.right.val == p.val;
            var isQdescent = isCurrQ || root.right.val == q.val;

            if (isPdescent && isQdescent)
                return root;

            return LowestCommonAncestor(root.right, p, q);
        }
        else if (p.val < root.val && q.val < root.val)
        {
            var isPdescent = isCurrP || root.left.val == p.val;
            var isQdescent = isCurrQ || root.left.val == q.val;

            if (isPdescent && isQdescent)
                return root;

            return LowestCommonAncestor(root.left, p, q);
        }

        return root;
    }
}
