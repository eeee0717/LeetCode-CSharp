/*
 * @lc app=leetcode.cn id=83 lang=csharp
 * @lcpr version=30118
 *
 * [83] 删除排序链表中的重复元素
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
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null) return null;
        var pre = head;
        var cur = head.next;
        while (cur != null)
        {
            if (pre.val != cur.val)
            {
                pre.next = cur;
                pre = pre.next;
            }
            if (cur.next == null)
            {
                pre.next = null;
            }
            cur = cur.next;

        }

        return head;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,1,2]\n
// @lcpr case=end

// @lcpr case=start
// [1,1,2,2,3,3]\n
// @lcpr case=end

 */

