/*
 * @lc app=leetcode.cn id=707 lang=csharp
 *
 * [707] 设计链表
 */

// @lc code=start

class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val) { this.val = val; }
}
public class MyLinkedList
{
    ListNode dummyHead;
    int count;

    public MyLinkedList()
    {
        dummyHead = new ListNode(0);
        count = 0;
    }

    public int Get(int index)
    {
        if (index < 0 || count <= index) return -1;
        ListNode current = dummyHead;
        for (int i = 0; i <= index; i++)
        {
            current = current.next;
        }
        return current.val;
    }

    public void AddAtHead(int val)
    {
        AddAtIndex(0, val);
    }

    public void AddAtTail(int val)
    {
        AddAtIndex(count, val);
    }

    public void AddAtIndex(int index, int val)
    {
        if (index > count) return;
        index = Math.Max(0, index);
        count++;
        ListNode tmp1 = dummyHead;
        for (int i = 0; i < index; i++)
        {
            tmp1 = tmp1.next;
        }
        ListNode tmp2 = new ListNode(val);
        tmp2.next = tmp1.next;
        tmp1.next = tmp2;
    }

    public void DeleteAtIndex(int index)
    {

        if (index >= count || index < 0) return;
        var tmp1 = dummyHead;
        for (int i = 0; i < index; i++)
        {
            tmp1 = tmp1.next;
        }
        tmp1.next = tmp1.next.next;
        count--;

    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */
// @lc code=end

