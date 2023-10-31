/*
 * @lc app=leetcode.cn id=24 lang=csharp
 *
 * [24] 两两交换链表中的节点
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
public class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        // var dummyHead = new ListNode();
        // dummyHead.next = head;
        // ListNode cur = dummyHead;
        // while (cur.next != null && cur.next.next != null)
        // {
        //     ListNode tmp1 = cur.next;
        //     ListNode tmp2 = cur.next.next.next;

        //     cur.next = cur.next.next;
        //     cur.next.next = tmp1;
        //     cur.next.next.next = tmp2;

        //     cur = cur.next.next;
        // }
        // return dummyHead.next;
        if (head == null || head.next == null) return head;
        var cur = head.next;
        head.next = SwapPairs(head.next.next);
        cur.next = head;
        return cur;

    }
}
// @lc code=end

