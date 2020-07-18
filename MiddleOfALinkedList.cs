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
    public ListNode MiddleNode(ListNode head) {
        var first = head;
        var second = head;
        while(second != null && second.next != null){
            second = second.next.next;
            first = first.next;
        }
        return first;
    }
}