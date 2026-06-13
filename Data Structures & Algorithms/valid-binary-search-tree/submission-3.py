class Solution:
    def dfs(self, node, min, max):

        result = True
        while node and result:
            if(node.val <= min or node.val >= max):
                return False
            
            if node.right:
                result = self.dfs(node.right, node.val, max)

            if result and node.left:
                result = self.dfs(node.left,  min, node.val)

            break

        return result


    def isValidBST(self, root: Optional[TreeNode]) -> bool:
        if(root == None):
            return False

        negative_infinity = float('-inf')
        positive_infinity = float('inf')

        return self.dfs(root, negative_infinity, positive_infinity)   