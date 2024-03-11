/*
 * @lc app=leetcode.cn id=445 lang=csharp
 * @lcpr version=30119
 *
 * [445] 两数相加 II
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var list1 = Reversal(l1);
        var list2 = Reversal(l2);
        var head3 = AddList(list1, list2);
        return Reversal(head3);

    }
    public ListNode Reversal(ListNode head)
    {
        if (head == null || head.next == null) return head;
        var newHead = Reversal(head.next);
        head.next.next = head;
        head.next = null;
        return newHead;
    }
    public ListNode AddList(ListNode head1, ListNode head2)
    {
        var carry = 0;
        var sum = 0;
        var head3 = new ListNode();
        var dummyHead = head3;
        while (head1 != null || head2 != null)
        {
            var x = head1 == null ? 0 : head1.val;
            var y = head2 == null ? 0 : head2.val;
            var tmp = x + y + carry;
            carry = tmp / 10;
            tmp %= 10;
            head3.next = new ListNode(tmp);
            head3 = head3.next;
            if (head1 != null) head1 = head1.next;
            if (head2 != null) head2 = head2.next;
        }
        if (carry > 0)
        {
            head3.next = new ListNode(carry);
        }
        return dummyHead.next;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [7,2,4,3]\n[5,6,4]\n
// @lcpr case=end

// @lcpr case=start
// [2,4,3]\n[5,6,4]\n
// @lcpr case=end

// @lcpr case=start
// [0]\n[0]\n
// @lcpr case=end

 */

