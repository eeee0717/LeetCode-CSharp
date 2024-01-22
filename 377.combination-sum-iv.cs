/*
 * @lc app=leetcode.cn id=377 lang=csharp
 * @lcpr version=30113
 *
 * [377] 组合总和 Ⅳ
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CombinationSum4(int[] nums, int target)
    {
        int[] dp = new int[target + 1];
        dp[0] = 1;
        for (int i = 0; i <= target; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i >= nums[j] && dp[i] < int.MaxValue - dp[i - nums[j]])
                {
                    dp[i] += dp[i - nums[j]];
                }
            }
        }
        return dp[target];
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3]\n4\n
// @lcpr case=end

// @lcpr case=start
// [9]\n3\n
// @lcpr case=end

 */

