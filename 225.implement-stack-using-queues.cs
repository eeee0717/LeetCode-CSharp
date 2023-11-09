/*
 * @lc app=leetcode.cn id=225 lang=csharp
 * @lcpr version=30106
 *
 * [225] 用队列实现栈
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class MyStack
{
    Queue<int> que;

    public MyStack()
    {
        que = new Queue<int>();
    }

    public void Push(int x)
    {
        int size = que.Count();
        que.Enqueue(x);
        while (size-- != 0)
        {
            que.Enqueue(que.Dequeue());
        }
    }

    public int Pop()
    {
        return que.Dequeue();

    }

    public int Top()
    {
        return que.Peek();
    }

    public bool Empty()
    {
        return que.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
// @lc code=end



/*
// @lcpr case=start
// ["MyStack", "push", "push", "top", "pop", "empty"][[], [1], [2], [], [], []]\n
// @lcpr case=end

 */

