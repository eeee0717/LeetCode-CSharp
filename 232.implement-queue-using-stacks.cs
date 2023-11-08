/*
 * @lc app=leetcode.cn id=232 lang=csharp
 * @lcpr version=30105
 *
 * [232] 用栈实现队列
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class MyQueue
{
    Stack<int> stIn;
    Stack<int> stOut;

    public MyQueue()
    {
        stIn = new Stack<int>();
        stOut = new Stack<int>();
    }

    public void Push(int x)
    {
        stIn.Push(x);
    }

    public int Pop()
    {
        dumpStackIn();
        return stOut.Pop();
    }

    public int Peek()
    {
        dumpStackIn();
        return stOut.Peek();
    }

    public bool Empty()
    {
        return stIn.Count == 0 && stOut.Count == 0;
    }

    public void dumpStackIn()
    {
        if (stOut.Count != 0) return;
        while (stIn.Count != 0)
        {
            stOut.Push(stIn.Pop());
        }
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
// @lc code=end



/*
// @lcpr case=start
// ["MyQueue", "push", "push", "peek", "pop", "empty"][[], [1], [2], [], [], []]\n
// @lcpr case=end

 */

