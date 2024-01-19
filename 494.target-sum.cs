/*
 * @lc app=leetcode.cn id=494 lang=csharp
 * @lcpr version=30113
 *
 * [494] 目标和
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int FindTargetSumWays(int[] nums, int target)
    {
        int sum = 0;
        foreach (int num in nums)
        {
            sum += num;
        }
        if (Math.Abs(target) > sum) return 0;
        if ((sum + target) % 2 == 1) return 0;
        int bagSize = (sum + target) / 2;
        int[] dp = new int[bagSize + 1];
        dp[0] = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = bagSize; j >= nums[i]; j--)
            {
                dp[j] += dp[j - nums[i]];
            }
        }
        return dp[bagSize];
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,1,1,1,1]\n3\n
// @lcpr case=end

// @lcpr case=start
// [1]\n1\n
// @lcpr case=end

 */

