/*
 * @lc app=leetcode.cn id=203 lang=csharp
 *
 * [203] 移除链表元素
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
    public ListNode RemoveElements(ListNode head, int val)
    {
        // ListNode dummyHead = new ListNode(0);
        // dummyHead.next = head;
        // ListNode current = head;
        // while (current.next != null)
        // {
        //     if (current.next.val == val)
        //     {
        //         current.next = current.next.next;
        //     }
        //     else
        //     {
        //         current = current.next;

        //     }
        // }
        // return dummyHead.next;

        if (head == null)
            return head;
        head.next = RemoveElements(head.next, val);
        return head.val == val ? head.next : head;
    }
}
// @lc code=end

