class Solution:

    def rec(self, root, curr):
        if not curr:
            return root
        
        root = self.rec(root, curr.next)
        if not root:
            return None

        temp = None
        if root == curr or root.next == curr:
            curr.next = None
        else:
            temp = root.next
            root.next = curr
            curr.next = temp
        
        return temp
            
        

    def reorderList(self, head: Optional[ListNode]) -> None:
    
        self.rec(head, head)