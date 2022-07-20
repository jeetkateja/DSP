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
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        if(head.next == null)
            return null;
        
        ListNode temp = head;
        int cnt = 0;
        while(temp != null)
        {
            temp = temp.next;
            cnt++;
        }
        
        cnt = cnt-n;
        if(cnt == 0)
        {
            return head.next;
        }
        
        temp = head;
        while(cnt > 1)
        {
            temp = temp.next;
            cnt--;
            
        }
        temp.next = temp.next.next;
        return head;
    }
}