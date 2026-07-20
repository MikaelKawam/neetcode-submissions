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
            currentNode = stack.pop()

            if currentNode:
                currentNode.right, currentNode.left = currentNode.left, currentNode.right

                stack.append(currentNode.right)
                stack.append(currentNode.left)

            
        return root


        