/*
 * @lc app=leetcode.cn id=19 lang=csharp
 *
 * [19] 删除链表的倒数第 N 个结点
 */

// @lc code=start
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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var dummyHead = new ListNode();
        dummyHead.next = head;

        var f = dummyHead;
        var s = dummyHead;
        while(n-- >0 && f.next != null){
            f = f.next;
        }

        while (f.next!=null)
        {
            f = f.next;
            s = s.next;
        }
        s.next = s.next.next;
        return dummyHead.next;
    }
}
// @lc code=end

