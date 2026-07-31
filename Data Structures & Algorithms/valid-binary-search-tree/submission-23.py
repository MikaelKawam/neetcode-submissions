# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def bstValidInterval(self, root, min, max):
        if not root: return True

        if root.left:
            if root.val <= root.left.val or root.left.val <= min:
                return False

        if root.right:
            if root.val >= root.right.val or root.right.val >= max:
                return False

        return self.bstValidInterval(root.left, min, root.val) and self.bstValidInterval(root.right, root.val, max)
        

    def isValidBST(self, root: Optional[TreeNode]) -> bool:
        return  self.bstValidInterval(root, float('-inf'), float('inf'))
        