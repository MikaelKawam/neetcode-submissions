# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def invertTree(self, root: Optional[TreeNode]) -> Optional[TreeNode]:
        stack = [root]

        while stack:
            current = stack.pop()

            if current:
                current.right, current.left = current.left, current.right

                stack.append(current.right)
                stack.append(current.left)

            
        return root


        