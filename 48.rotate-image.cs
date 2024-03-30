/*
 * @lc app=leetcode.cn id=48 lang=csharp
 * @lcpr version=30121
 *
 * [48] 旋转图像
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public void Rotate(int[][] matrix)
    {
        int n = matrix.Length;
        for (int i = 0; i < n/2; i++)
        {
            for (int j = 0; j < n; j++)
            {
                (matrix[i][j], matrix[n - i - 1][j]) = (matrix[n - i - 1][j], matrix[i][j]);
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
            }
        }
        return;

    }
}
// @lc code=end



/*
// @lcpr case=start
// [[1,2,3],[4,5,6],[7,8,9]]\n
// @lcpr case=end

// @lcpr case=start
// [[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]]\n
// @lcpr case=end

 */

