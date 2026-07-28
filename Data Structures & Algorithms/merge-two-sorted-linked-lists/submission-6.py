class Solution:    
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        dummy = head = ListNode()
        while list1 and list2:
            if list1.val > list2.val:
                dummy.next = list2
                dummy = dummy.next
                list2 = list2.next
            else:
                dummy.next = list1
                dummy = dummy.next
                list1 = list1.next


        dummy.next = list1 or list2

        return head.next