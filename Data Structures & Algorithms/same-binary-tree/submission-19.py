# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def isSameTree(self, p: Optional[TreeNode], q: Optional[TreeNode]) -> bool:
        q1,  q2 = deque(), deque()
        q1.append(p)
        q2.append(q)

        while q1 and q2:
            nodep = q1.popleft()
            nodeq = q2.popleft()
            if not nodep and not nodeq:
                continue
            if not nodep or not nodeq:
                return False 
            if not (nodep.val == nodeq.val):
                return False

            q1.append(nodep.right) 
            q1.append(nodep.left) 
            q2.append(nodeq.right) 
            q2.append(nodeq.left) 
        
        return True
                            