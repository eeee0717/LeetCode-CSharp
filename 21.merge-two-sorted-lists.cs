/*
 * @lc app=leetcode.cn id=21 lang=csharp
 * @lcpr version=30117
 *
 * [21] 合并两个有序链表
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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode list3 = new ListNode();
        Recursion(list1, list2, list3);
        return list3.next;
    }
    public void Recursion(ListNode node1, ListNode node2, ListNode node3)
    {
        if (node1 == null)
        {
            node3.next = node2;
            return;
        }
        if (node2 == null)
        {
            node3.next = node1;
            return;
        }
        if (node1.val >= node2.val)
        {
            node3.next = node2;
            node2 = node2.next;
        }
        else
        {
            node3.next = node1;
            node1 = node1.next;
        }
        Recursion(node1, node2, node3.next);

    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,4]\n[1,3,4]\n
// @lcpr case=end

// @lcpr case=start
// []\n[]\n
// @lcpr case=end

// @lcpr case=start
// []\n[0]\n
// @lcpr case=end

 */

