/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        var sortedList = new List<int>();
        while (l1 != null){
            sortedList.Add(l1.val);
            l1 = l1.next;
        }
        while (l2 != null){
            sortedList.Add(l2.val);
            l2 = l2.next;
        }
        sortedList.Sort();
        var result = new ListNode(-1);
        var r1 = result;
        foreach (var value in sortedList){
            r1.next = new ListNode(value);
            r1 = r1.next;
        }
        return result.next;
    }
}