/*
 * @lc app=leetcode.cn id=55 lang=csharp
 * @lcpr version=30112
 *
 * [55] 跳跃游戏
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool CanJump(int[] nums)
    {
        int cover = 0;
        if (nums.Length == 1) return true;
        for (int i = 0; i <= cover; i++)
        {
            cover = Math.Max(i + nums[i], cover);
            if (cover >= nums.Length - 1) return true;
        }
        return false;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,3,1,1,4]\n
// @lcpr case=end

// @lcpr case=start
// [3,2,1,0,4]\n
// @lcpr case=end

 */

