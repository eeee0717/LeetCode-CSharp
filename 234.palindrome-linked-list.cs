/*
 * @lc app=leetcode.cn id=234 lang=csharp
 * @lcpr version=30114
 *
 * [234] 回文链表
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
    public bool IsPalindrome(ListNode head)
    {
        List<int> arr = new List<int>();
        var cur = head;
        while (cur != null)
        {
            arr.Add(cur.val);
            cur = cur.next;
        }
        int slow = 0, fast = arr.Count - 1;
        while (slow < fast)
        {
            if (arr[slow] != arr[fast]) return false;
            slow++;
            fast--;
        }
        return true;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,2,1]\n
// @lcpr case=end

// @lcpr case=start
// [1,2]\n
// @lcpr case=end

 */

