class Solution:    
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        dummy = head = ListNode()
        while list1 and list2:
            if list1.val > list2.val:
                dummy.next = list2
                list2 = list2.next
            else:
                dummy.next = list1
                list1 = list1.next
            dummy = dummy.next
            


        dummy.next = list1 or list2

        return head.next

    def mergeKLists(self, lists: List[Optional[ListNode]]) -> Optional[ListNode]:
        if len(lists) == 0: return None
        
        while len(lists) > 1:
            curr1 = lists.pop()
            curr2 = lists.pop()
            
            lists.append(self.mergeTwoLists(curr1, curr2))

        return lists.pop()