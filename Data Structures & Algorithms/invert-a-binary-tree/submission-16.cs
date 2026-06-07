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

public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        TreeNode Inverter(TreeNode _root)
        {
            if (_root == null) return _root;

            var temp = _root.right;
            _root.right = _root.left;
            _root.left = temp;

            Inverter(_root.right);
            Inverter(_root.left);

            return _root;
        }

        return Inverter(root);
    }
}
