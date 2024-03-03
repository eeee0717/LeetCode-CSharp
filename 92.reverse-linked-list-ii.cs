/*
 * @lc app=leetcode.cn id=92 lang=csharp
 * @lcpr version=30118
 *
 * [92] 反转链表 II
 */


// @lcpr-template-start

// @lcpr-template-end
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
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        var dummyHead = new ListNode();
        var cur = dummyHead;
        for (int i = 1; i < left; i++)
        {
            cur.next = head;
            cur = head;
            head = head.next;
        }

        var pre = cur;
        var start = head;

        for (int i = left; i <= right; i++)
        {
            var tmp = head;
            head = head.next;
            tmp.next = pre;
            pre = tmp;
        }
        start.next = head;
        cur.next = pre;
        return dummyHead.next;

    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,4,5]\n2\n4\n
// @lcpr case=end

// @lcpr case=start
// [5]\n1\n1\n
// @lcpr case=end

 */

