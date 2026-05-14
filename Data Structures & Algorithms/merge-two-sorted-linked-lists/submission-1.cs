/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    ListNode newHead = null;
    ListNode tail = null;

    while (list1 != null && list2 != null)
    {
        ListNode chosen;

        if (list1.val < list2.val)
        {
            chosen = list1;
            list1 = list1.next;
        }
        else
        {
            chosen = list2;
            list2 = list2.next;
        }

        if (newHead == null)
        {
            newHead = chosen;
            tail = chosen;
        }
        else
        {
            tail.next = chosen;
            tail = chosen;
        }
    }

    if (newHead == null)
        return list1 ?? list2;

    tail.next = list1 ?? list2;

    return newHead;
}
}