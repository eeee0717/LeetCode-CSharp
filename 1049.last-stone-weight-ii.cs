/*
 * @lc app=leetcode.cn id=1049 lang=csharp
 * @lcpr version=30113
 *
 * [1049] 最后一块石头的重量 II
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int LastStoneWeightII(int[] stones)
    {
        int[] dp = new int[15001];
        int sum = 0;
        foreach (int stone in stones)
        {
            sum += stone;
        }
        int target = sum / 2;
        for (int i = 0; i < stones.Length; i++)
        {
            for (int j = target; j >= stones[i]; j--)
            {
                dp[j] = Math.Max(dp[j], dp[j - stones[i]] + stones[i]);
            }
        }
        return sum - 2 * dp[target];
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,7,4,1,8,1]\n
// @lcpr case=end

// @lcpr case=start
// [31,26,33,21,40]\n
// @lcpr case=end

 */

