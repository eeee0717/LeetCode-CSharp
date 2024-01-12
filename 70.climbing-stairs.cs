/*
 * @lc app=leetcode.cn id=70 lang=csharp
 * @lcpr version=30113
 *
 * [70] 爬楼梯
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n <= 2) return n;
        var dp = new int[n + 1];
        dp[1] = 1; 
        dp[2] = 2;
        for (int i = 3; i <= n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
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
// 3\n
// @lcpr case=end

 */

