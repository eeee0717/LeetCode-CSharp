/*
 * @lc app=leetcode.cn id=474 lang=csharp
 * @lcpr version=30113
 *
 * [474] 一和零
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int FindMaxForm(string[] strs, int m, int n)
    {
        int[,] dp = new int[m + 1, n + 1];
        foreach (string str in strs)
        {
            int zero = 0, one = 0;
            foreach (char c in str)
            {
                if (c == '0') zero++;
                else one++;
            }
            for (int i = m; i >= zero; i--)
            {
                for (int j = n; j >= one; j--)
                {
                    dp[i, j] = Math.Max(dp[i, j], dp[i - zero, j - one] + 1);
                }
            }
        }
        return dp[m, n];
    }
}
// @lc code=end



/*
// @lcpr case=start
// ["10", "0001", "111001", "1", "0"]\n5\n3\n
// @lcpr case=end

// @lcpr case=start
// ["10", "0", "1"]\n1\n1\n
// @lcpr case=end

 */

