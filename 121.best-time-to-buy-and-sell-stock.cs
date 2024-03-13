/*
 * @lc app=leetcode.cn id=121 lang=csharp
 * @lcpr version=30119
 *
 * [121] 买卖股票的最佳时机
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int minPrice = Int32.MaxValue;
        int profit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else if (prices[i] - minPrice > profit)
            {
                profit = prices[i] - minPrice;
            }
        }
        return profit;

    }
}
// @lc code=end



/*
// @lcpr case=start
// [7,1,5,3,6,4]\n
// @lcpr case=end

// @lcpr case=start
// [7,6,4,3,1]\n
// @lcpr case=end

 */

