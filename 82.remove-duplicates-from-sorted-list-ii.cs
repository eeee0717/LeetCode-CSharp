/*
 * @lc app=leetcode.cn id=82 lang=csharp
 * @lcpr version=30118
 *
 * [82] 删除排序链表中的重复元素 II
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
        if(head == null)
         return head;
         ListNode dummyHead = new ListNode();
         dummyHead.next = head;
         var cur = dummyHead;
         while(cur.next != null && cur.next.next != null)
         {
            if( cur.next.val == cur.next.next.val)
            {
                int x = cur.next.val;
                while(cur.next != null && cur.next.val == x)
                {
                    cur.next = cur.next.next;
                }
            }
            else{
                cur = cur.next;
            }
         }
         return dummyHead.next;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,3,4,4,5]\n
// @lcpr case=end

// @lcpr case=start
// [1,1,1,2,3]\n
// @lcpr case=end

 */

