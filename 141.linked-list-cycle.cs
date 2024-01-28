/*
 * @lc app=leetcode.cn id=141 lang=csharp
 * @lcpr version=30113
 *
 * [141] 环形链表
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
    public bool HasCycle(ListNode head)
    {
        if (head == null || head.next == null) return false;
        var fast = head.next;
        var slow = head;
        while (fast != slow)
        {
            if(fast.next == null || fast.next.next == null) return false;
            fast = fast.next.next;
            slow = slow.next;
        }
        return true;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,2,0,-4]\n1\n
// @lcpr case=end

// @lcpr case=start
// [1,2]\n0\n
// @lcpr case=end

// @lcpr case=start
// [1]\n-1\n
// @lcpr case=end

 */

