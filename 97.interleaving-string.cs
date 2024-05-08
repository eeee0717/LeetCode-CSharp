/*
 * @lc app=leetcode.cn id=97 lang=csharp
 * @lcpr version=30201
 *
 * [97] 交错字符串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool IsInterleave(string s1, string s2, string s3)
    {
        int m = s1.Length, n = s2.Length;
        if (s3.Length != m + n) return false;
        bool[,] dp = new bool[m + 1, n + 1];
        dp[0,0] = true;
        var charS1 = s1.ToCharArray();
        var charS2 = s2.ToCharArray();
        var charS3 = s3.ToCharArray();
        for (int i = 1; i <= m && charS1[i - 1] == charS3[i - 1]; i++) dp[i, 0] = true;
        for (int j = 1; j <= n && charS2[j - 1] == charS3[j - 1]; j++) dp[0, j] = true;
        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                dp[i, j] = (dp[i - 1, j] && charS3[i + j - 1] == charS1[i - 1]) || (dp[i, j - 1] && charS3[i + j - 1] == charS2[j - 1]);
            }
        }
        return dp[m,n];
    }
}
// @lc code=end



/*
// @lcpr case=start
// "aabcc"\n"dbbca"\n"aadbbcbcac"\n
// @lcpr case=end

// @lcpr case=start
// "aabcc"\n"dbbca"\n"aadbbbaccc"\n
// @lcpr case=end

// @lcpr case=start
// ""\n""\n""\n
// @lcpr case=end

 */

