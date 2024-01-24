/*
 * @lc app=leetcode.cn id=2865 lang=csharp
 * @lcpr version=30113
 *
 * [2865] 美丽塔 I
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public long MaximumSumOfHeights(IList<int> maxHeights)
    {
        int n = maxHeights.Count;
        long res = 0;
        long[] prefix = new long[n];
        long[] suffix = new long[n];
        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();
        for (int i = 0; i < n; i++)
        {
            while (stack1.Count > 0 && maxHeights[i] < maxHeights[stack1.Peek()])
            {
                stack1.Pop();
            }
            if (stack1.Count == 0)
            {
                prefix[i] = (long) (i + 1) * maxHeights[i];
            }
            else
            {
                prefix[i] = prefix[stack1.Peek()] +(long) (i - stack1.Peek()) * maxHeights[i];
            }
            stack1.Push(i);
        }
        for (int i = n - 1; i >= 0; i--)
        {
            while (stack2.Count > 0 && maxHeights[i] < maxHeights[stack2.Peek()])
            {
                stack2.Pop();
            }
            if (stack2.Count == 0)
            {
                suffix[i] = (long) (n - i) * maxHeights[i];
            }
            else
            {
                suffix[i] = suffix[stack2.Peek()] + (long)(stack2.Peek() - i) * maxHeights[i];
            }
            stack2.Push(i);
            res = Math.Max(res, prefix[i] + suffix[i] - maxHeights[i]);
        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [5,3,4,1,1]\n
// @lcpr case=end

// @lcpr case=start
// [6,5,3,9,2,7]\n
// @lcpr case=end

// @lcpr case=start
// [3,2,5,5,2,3]\n
// @lcpr case=end

 */

