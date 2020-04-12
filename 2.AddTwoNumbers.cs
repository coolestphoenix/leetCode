/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        return Add(l1, l2, 0);
    }
    private ListNode Add(ListNode l1, ListNode l2, int carryBit){
        if(l1 == null && l2 == null){
            if(carryBit > 0)
            {
                return new ListNode(carryBit);
            }
            return null;
        }
        int firstValue =0 , secondValue = 0;
        if(l1 != null) {
            firstValue = l1.val;
        }
        if(l2 != null){
            secondValue = l2.val;
        }
        int sum = firstValue + secondValue + carryBit;
        carryBit = 0;
        if(sum >= 10){
            carryBit = sum / 10;
            sum = sum % 10;
        }
        var newNode = new ListNode(sum);
        ListNode nextNode = null;
        if(l1?.next != null || l2?.next != null || carryBit > 0){
            nextNode = Add(l1?.next, l2?.next, carryBit);
        }
        if(nextNode != null)
            newNode.next = nextNode;
        
        return newNode;
    }
}