# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:   
    def isSameTree(self, p, q):
        q1, q2 = deque([p]), deque([q])

        while q1 and q2:
            for _ in range(len(q1)):
                nodeP = q1.popleft()
                nodeQ = q2.popleft()

                if nodeP is None and nodeQ is None:
                    continue
                if nodeP is None or nodeQ is None or nodeP.val != nodeQ.val:
                    return False
                q1.append(nodeP.left)
                q1.append(nodeP.right)
                q2.append(nodeQ.left)
                q2.append(nodeQ.right)

        return True



    def isSubtree(self, root: Optional[TreeNode], subRoot: Optional[TreeNode]) -> bool:

        q = deque([root])

        while q:
            for _ in range(len(q)):
                node = q.popleft()
                if node is None: 
                    continue 

                if node.val == subRoot.val:
                    if self.isSameTree(node, subRoot):
                        return True
            
                q.append(node.right)
                q.append(node.left)

        return False
                    
