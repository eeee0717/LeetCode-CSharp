/*
 * @lc app=leetcode.cn id=198 lang=csharp
 * @lcpr version=30121
 *
 * [198] 打家劫舍
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int Rob(int[] nums)
    {
        int pre = 0,  cur = 0;
        foreach (int i in nums)
        {
            int tmp = Math.Max(cur, pre + i);
            pre = cur;
            cur = tmp;
        }
        return cur;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,1]\n
// @lcpr case=end

// @lcpr case=start
// [2,7,9,3,1]\n
// @lcpr case=end

 */

