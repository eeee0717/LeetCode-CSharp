/*
 * @lc app=leetcode.cn id=74 lang=csharp
 * @lcpr version=30122
 *
 * [74] 搜索二维矩阵
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int m = matrix.Length, n = matrix[0].Length;
        int l = 0, r = m * n - 1;
        while (l < r)
        {
            int mid = l + r + 1 >> 1;
            if (matrix[mid / n][mid % n] > target)
            {
                r = mid - 1;
            }
            else
            {
                l = mid;
            }
        }
        return matrix[r / n][r % n] == target;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[1,3,5,7],[10,11,16,20],[23,30,34,60]]\n3\n
// @lcpr case=end

// @lcpr case=start
// [[1,3,5,7],[10,11,16,20],[23,30,34,60]]\n13\n
// @lcpr case=end

 */

