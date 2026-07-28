# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:

    def countDepth(self, count, root):
        if not root: return count
        countLeft, countRight = count, count

        countLeft = self.countDepth(countLeft + 1, root.left)
        countRight = self.countDepth(countRight + 1, root.right)

        return max(countLeft, countRight)
    
    def maxDepth(self, root: Optional[TreeNode]) -> int:
        if not root: return 0

        countLeft, countRight = 0, 0
        countLeft = self.countDepth(countLeft + 1, root.left)
        countRight = self.countDepth(countRight + 1, root.right)
        
        return max(countLeft, countRight)

