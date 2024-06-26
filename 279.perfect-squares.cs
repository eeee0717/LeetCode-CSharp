/*
 * @lc app=leetcode.cn id=279 lang=csharp
 * @lcpr version=30121
 *
 * [279] 完全平方数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int NumSquares(int n)
    {
        int[] dp = new int[n + 1];
        dp[0] = 0;
        for (int i = 1; i <= n; i++)
        {
            dp[i] = i;
            for (int j = 1; i - j * j >= 0; j++)
            {
                dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
            }
        }
        return dp[n];

    }
}
// @lc code=end



/*
// @lcpr case=start
// 12\n
// @lcpr case=end

// @lcpr case=start
// 13\n
// @lcpr case=end

 */

