# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        node = head
        newHead = None
        while node:
            next = node.next

            node.next = newHead
            newHead = node
            node = next



        return newHead