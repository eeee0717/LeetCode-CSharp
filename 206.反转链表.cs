/*
 * @lc app=leetcode.cn id=206 lang=csharp
 *
 * [206] 反转链表
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
    public ListNode Reverse(ListNode pre, ListNode cur)
    {
        if(cur==null) return pre;
        ListNode tmp = cur.next;
        cur.next = pre;
        return Reverse(cur, tmp);
    }

    public ListNode ReverseList(ListNode head)
    {
        return Reverse(null, head);
        // if (head == null) return null;
        // ListNode pre = null;
        // ListNode cur = head;
        // while(cur!=null)
        // {
        //     ListNode tmp = cur.next;
        //     cur.next = pre;
        //     pre = cur;
        //     cur = tmp;
        // }
        // return pre;


    }
}
// @lc code=end

