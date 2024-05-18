/*
 * @lc app=leetcode.cn id=503 lang=csharp
 * @lcpr version=30202
 *
 * [503] 下一个更大元素 II
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] NextGreaterElements(int[] nums)
    {
        int n = nums.Length;
        int[] ret = new int[n];
        Array.Fill(ret, -1);
        Stack<int> st = new Stack<int>();
        for (int i = 0; i < 2 * n - 1; i++)
        {
            int num = nums[i % n];
            while (st.Count > 0 && nums[st.Peek()] < num)
            {
                ret[st.Pop()] = num;
            }
            st.Push(i % n);
        }
        return ret;

    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,1]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,4,3]\n
// @lcpr case=end

 */

