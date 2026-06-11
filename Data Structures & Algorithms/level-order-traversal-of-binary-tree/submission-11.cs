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
    public List<List<int>> LevelOrder(TreeNode root)
{
    if (root == null)
        return new List<List<int>>();

    var result = new List<List<int>>
    {
        new List<int> { root.val }
    };

    var left = LevelOrder(root.left);
    var right = LevelOrder(root.right);

    var commonLevels = Math.Min(left.Count, right.Count);

    for (int i = 0; i < commonLevels; i++)
    {
        left[i].AddRange(right[i]);
    }

    result.AddRange(left);

    if (left.Count < right.Count)
    {
        for (int i = left.Count; i < right.Count; i++)
        {
            result.Add(right[i]);
        }
    }

    return result;
}
}
