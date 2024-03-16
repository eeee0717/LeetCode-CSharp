/*
 * @lc app=leetcode.cn id=300 lang=csharp
 * @lcpr version=30119
 *
 * [300] 最长递增子序列
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int LengthOfLIS(int[] nums)
    {
        if (nums.Length == 0) return 0;
        int[] dp = new int[nums.Length];
        Array.Fill(dp, 1);
        int res = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[i] > nums[j]) dp[i] = Math.Max(dp[i], dp[j] + 1);
            }
            res = Math.Max(res, dp[i]);
        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [10,9,2,5,3,7,101,18]\n
// @lcpr case=end

// @lcpr case=start
// [0,1,0,3,2,3]\n
// @lcpr case=end

// @lcpr case=start
// [7,7,7,7,7,7,7]\n
// @lcpr case=end

 */

