/*
 * @lc app=leetcode.cn id=221 lang=csharp
 * @lcpr version=30119
 *
 * [221] 最大正方形
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaximalSquare(char[][] matrix)
    {
        if (matrix == null || matrix.Length < 1 || matrix[0].Length < 1) return 0;

        int h = matrix.Length;
        int w = matrix[0].Length;
        int maxSide = 0;
        int[,] dp = new int[h + 1, w + 1];
        for (int row = 0; row < h; row++)
        {
            for (int col = 0; col < w; col++)
            {
                if (matrix[row][col] == '1')
                {
                    dp[row + 1, col + 1] = Math.Min(Math.Min(dp[row + 1, col], dp[row, col + 1]), dp[row, col]) + 1;

                    maxSide = Math.Max(maxSide, dp[row + 1, col + 1]);
                }


            }
        }
        return maxSide * maxSide;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [["1","0","1","0","0"],["1","0","1","1","1"],["1","1","1","1","1"],["1","0","0","1","0"]]\n
// @lcpr case=end

// @lcpr case=start
// [["0","1"],["1","0"]]\n
// @lcpr case=end

// @lcpr case=start
// [["0"]]\n
// @lcpr case=end

 */

