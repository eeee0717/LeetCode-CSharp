/*
 * @lc app=leetcode.cn id=498 lang=csharp
 * @lcpr version=30122
 *
 * [498] 对角线遍历
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] FindDiagonalOrder(int[][] mat)
    {
        if (mat.Length == 0 || mat[0].Length == 0) return new int[0]; 
        int n = mat.Length;
        int m = mat[0].Length;
        int[] res = new int[m * n];
        for (int i = 0, idx = 0; i < n + m - 1; i++)
        {
            if (i % 2 == 0)
            {
                for (int x = Math.Min(i, n - 1); x >= Math.Max(0, i - m + 1); x--)
                {
                    res[idx++] = mat[x][i - x];
                }
            }
            else
            {
                for (int x = Math.Max(0, i - m + 1); x <= Math.Min(i, n - 1); x++)
                {
                    res[idx++] = mat[x][i - x];
                }
            }
        }
        return res;

    }
}
// @lc code=end



/*
// @lcpr case=start
// [[1,2,3],[4,5,6],[7,8,9]]\n
// @lcpr case=end

// @lcpr case=start
// [[1,2],[3,4]]\n
// @lcpr case=end

 */

