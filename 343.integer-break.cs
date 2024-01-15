/*
 * @lc app=leetcode.cn id=343 lang=csharp
 * @lcpr version=30113
 *
 * [343] 整数拆分
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int IntegerBreak(int n)
    {
        int[] dp = new int[n + 1];
        dp[2] = 1;
        for (int i = 3; i <= n; i++)
        {
            for (int j = 1; j <= i / 2; j++)
            {
                dp[i] = Math.Max(dp[i],Math.Max(j*(i-j),j*dp[i-j]));
            }
        }
        return dp[n];
    }
}
// @lc code=end



/*
// @lcpr case=start
// 2\n
// @lcpr case=end

// @lcpr case=start
// 10\n
// @lcpr case=end

 */

