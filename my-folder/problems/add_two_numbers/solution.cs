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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        ListNode result = new ListNode();
        ListNode curr = result;
        int carry = 0, v1 = 0, v2=0, val = 0;
        
        
        while(l1 != null || l2 != null  || carry > 0)
        {
            v1 = (l1 != null) ? l1.val : 0;
            v2 = (l2 != null) ? l2.val : 0;
            
            val = v1+ v2 + carry;
            carry = val / 10;
            val = val %10;
            curr.next = new ListNode(val);
            
            curr = curr.next;
            l1 = (l1 != null) ? l1.next : l1;
            l2 = (l2 != null) ? l2.next : l2;
        }
        
        return result.next;
    }
}