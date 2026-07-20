class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        prev =  None
        tempNode = head

        while tempNode:
            tempNode = tempNode.next
            
            batata = head
            batata.next = prev
            prev = batata
            
            head = tempNode
            

        return prev