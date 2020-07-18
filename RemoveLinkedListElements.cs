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
    public ListNode RemoveElements(ListNode head, int val) {
        var dummy = new ListNode(0, head);
        var first = dummy;
        var second = dummy.next;
        while(second != null){
            if(second.val == val){
                first.next = second.next;
                second = second.next;
            }
            else {
             first = first.next;
             second = second.next;
            }
        }
        return dummy.next;
    }
}