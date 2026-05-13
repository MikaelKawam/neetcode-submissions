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
 
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode revHead = null;
        while (head != null)
        {
            var currRef = head;
            var nextRef = currRef.next;

            currRef.next = revHead;
            revHead = currRef;

            head = nextRef;
        }

        return revHead;
    }
}
