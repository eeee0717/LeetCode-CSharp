/*
 * @lc app=leetcode.cn id=322 lang=csharp
 * @lcpr version=30120
 *
 * [322] 零钱兑换
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CoinChange(int[] coins, int amount)
    {
        if(coins.Length == 0) return -1;
        int[] memo = new int[amount+1];
        memo[0] = 0;
        for(int i = 1; i <= amount; i++){
            int min = int.MaxValue;
            for(int j = 0; j < coins.Length; j++)
            {   
                if(i - coins[j] >=0 && memo[i-coins[j]] < min)
                {
                    min = memo[i-coins[j]]+1;
                }
            }
            memo[i] = min;
        }
        return memo[amount] == int.MaxValue ? -1 : memo[amount];
    }
    
}
// @lc code=end



/*
// @lcpr case=start
// [1, 2, 5]\n11\n
// @lcpr case=end

// @lcpr case=start
// [2]\n3\n
// @lcpr case=end

// @lcpr case=start
// [1]\n0\n
// @lcpr case=end

 */

