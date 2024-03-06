/*
 * @lc app=leetcode.cn id=148 lang=csharp
 * @lcpr version=30118
 *
 * [148] 排序链表
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
    public ListNode SortList(ListNode head)
    {
        var list = new List<int>();
        var dummyHead = new ListNode();
        dummyHead.next = head;
        while (head != null )
        {
            list.Add(head.val);
            head = head.next;
        }
        list.Sort();
        var cur = dummyHead;
        foreach(var item in list)
        {
            var tmp = new ListNode(item);
            cur.next = tmp;
            cur = cur.next;
        }
        return dummyHead.next;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [4,2,1,3]\n
// @lcpr case=end

// @lcpr case=start
// [-1,5,3,4,0]\n
// @lcpr case=end

// @lcpr case=start
// []\n
// @lcpr case=end

 */

