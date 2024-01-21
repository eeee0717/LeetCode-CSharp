/*
 * @lc app=leetcode.cn id=518 lang=csharp
 * @lcpr version=30113
 *
 * [518] 零钱兑换 II
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int Change(int amount, int[] coins)
    {
        int[] dp = new int[amount + 1];
        dp[0] = 1;
        for (int i = 0; i < coins.Length; i++)
        {
            for (int j = coins[i]; j <= amount; j++)
            {
                if (j >= coins[i])
                    dp[j] += dp[j - coins[i]];
            }
        }
        return dp[amount];
    }
}
// @lc code=end



/*
// @lcpr case=start
// 5\n[1, 2, 5]\n
// @lcpr case=end

// @lcpr case=start
// 3\n[2]\n
// @lcpr case=end

// @lcpr case=start
// 10\n[10]\n
// @lcpr case=end

 */

