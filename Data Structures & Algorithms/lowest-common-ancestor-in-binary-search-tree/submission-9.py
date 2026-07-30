# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def lowestCommonAncestor(self, root: TreeNode, p: TreeNode, q: TreeNode) -> TreeNode:
        queue = deque([root])

        res = root
        while queue:
            for _ in range(len(queue)):
                cur = queue.popleft()
                
                if p.val < cur.val and q.val < cur.val:
                    res = cur
                elif p.val > cur.val and q.val > cur.val:
                    res = cur
                else:
                    return cur
                    
                if cur.left:
                    queue.append(cur.left)

                if cur.right: 
                    queue.append(cur.right)

        return res
