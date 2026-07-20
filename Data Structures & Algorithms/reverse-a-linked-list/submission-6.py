class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        newNode =  None
        tempNode = head

        while tempNode:
            tempNode = tempNode.next
            
            curr = head
            curr.next = newNode
            newNode = curr
            
            head = tempNode
            

        return newNode