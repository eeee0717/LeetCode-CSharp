/*
 * @lc app=leetcode.cn id=61 lang=csharp
 * @lcpr version=30115
 *
 * [61] 旋转链表
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
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null) return head;
        int n = 1;
        var tail = head;
        while (tail.next != null)
        {
            tail = tail.next;
            n++;
        }
        k %= n;
        if (k == 0) return head;
        tail.next = head;
        int newTailIndex = n - k;
        var newTail = head;
        for (int i = 1; i < newTailIndex; i++)
        {
            newTail = newTail.next;
        }
        var newHead = newTail.next;
        newTail.next = null;
        return newHead;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,4,5]\n2\n
// @lcpr case=end

// @lcpr case=start
// [0,1,2]\n4\n
// @lcpr case=end

 */

