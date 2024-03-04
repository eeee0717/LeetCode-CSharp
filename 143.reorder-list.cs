/*
 * @lc app=leetcode.cn id=143 lang=csharp
 * @lcpr version=30118
 *
 * [143] 重排链表
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
    public void ReorderList(ListNode head)
    {
        if (head == null) return;
        var middle = MiddleNode(head);
        var l1 = head;
        var l2 = middle.next;
        middle.next = null;
        l2 = ReverseList(l2);
        MergeList(l1, l2);
    }
    public ListNode MiddleNode(ListNode head)
    {
        var fast = head;
        var slow = head;
        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
    public ListNode ReverseList(ListNode head)
    {
        ListNode pre = null;
        ListNode cur = head;
        while (cur != null)
        {
            var next = cur.next;
            cur.next = pre;
            pre = cur;
            cur = next;
        }
        return pre;
    }
    public void MergeList(ListNode l1, ListNode l2)
    {
        var tmp1 = l1;
        var tmp2 = l2;
        while (tmp1 != null && tmp2 != null)
        {
            tmp1 = l1.next;
            tmp2 = l2.next;

            l1.next = l2;
            l1 = tmp1;

            l2.next = l1;
            l2 = tmp2;
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,4]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,4,5]\n
// @lcpr case=end

 */

