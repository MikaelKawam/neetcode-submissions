# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

from queue import Queue

class Solution:
    def levelOrder(self, root: Optional[TreeNode]) -> List[List[int]]:
        if(root == None):
            return []
        
        res = []
        q = Queue()
        q.put(root)

        while q.qsize() > 0:
            qLen = q.qsize()
            level = []
            for i in range(qLen):
                node = q.get()
                if node:
                    level.append(node.val)
                    q.put(node.left)  
                    q.put(node.right)  
            if level:
                res.append(level)

        return res


        