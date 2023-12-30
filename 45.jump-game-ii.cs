/*
 * @lc app=leetcode.cn id=45 lang=csharp
 * @lcpr version=30112
 *
 * [45] 跳跃游戏 II
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int Jump(int[] nums)
    {
        int cur = 0, next = 0, step = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            next = Math.Max(next, i + nums[i]);
            if (i == cur)
            {
                cur = next;
                step++;
            }
        }
        return step;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,3,1,1,4]\n
// @lcpr case=end

// @lcpr case=start
// [2,3,0,1,4]\n
// @lcpr case=end

 */

