/*
 * @lc app=leetcode.cn id=135 lang=csharp
 * @lcpr version=30112
 *
 * [135] 分发糖果
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int Candy(int[] ratings)
    {
        int[] candies = new int[ratings.Length];
        for (int i = 0; i < candies.Length; i++)
        {
            candies[i] = 1;
        }
        for (int i = 1; i < ratings.Length; i++)
        {
            if (ratings[i] > ratings[i - 1])
            {
                candies[i] = candies[i - 1] + 1;
            }
        }
        for (int i = ratings.Length - 2; i >= 0; i--)
        {
            if (ratings[i] > ratings[i + 1])
            {
                candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
            }
        }
        return candies.Sum();
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,0,2]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,2]\n
// @lcpr case=end

 */

