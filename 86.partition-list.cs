/*
 * @lc app=leetcode.cn id=86 lang=csharp
 * @lcpr version=30116
 *
 * [86] 分隔链表
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
    public ListNode Partition(ListNode head, int x)
    {
        var smlDummy = new ListNode(0);
        var bigDummy = new ListNode(0);
        var sml = smlDummy; 
        var big = bigDummy;
        var cur = head;
        while (cur != null)
        {
            if (cur.val >= x)
            {
                big.next = cur;
                big = big.next;
            }
            else
            {
                sml.next = cur;
                sml = sml.next;
            }
            cur = cur.next;
        }
        sml.next = bigDummy.next;
        big.next = null;
        return smlDummy.next;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,4,3,2,5,2]\n3\n
// @lcpr case=end

// @lcpr case=start
// [2,1]\n2\n
// @lcpr case=end

 */

