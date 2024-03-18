/*
 * @lc app=leetcode.cn id=155 lang=csharp
 * @lcpr version=30119
 *
 * [155] 最小栈
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class MinStack
{
    Stack<int> stack;
    Stack<int> minStack;

    public MinStack()
    {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }

    public void Push(int val)
    {
        stack.Push(val);
        if (minStack.Count == 0 || minStack.Peek() >= val)
        {
            minStack.Push(val);
        }
    }

    public void Pop()
    {
        int val = stack.Pop();
        
        if (minStack.Peek() == val)
        {
            minStack.Pop();
        }
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return minStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
// @lc code=end



/*
// @lcpr case=start
// ["MinStack","push","push","push","getMin","pop","top","getMin"][[],[-2],[0],[-3],[],[],[],[]]\n
// @lcpr case=end

 */

