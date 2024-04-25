/*
 * @lc app=leetcode.cn id=695 lang=csharp
 * @lcpr version=30122
 *
 * [695] 岛屿的最大面积
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaxAreaOfIsland(int[][] grid)
    {
        int max = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    max = Math.Max(max, Dfs(grid, i, j));
                }
            }
        }
        return max;
    }
    public int Dfs(int[][] grid, int i, int j)
    {
        if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length || grid[i][j] == 0) return 0;
        int sum = 1;
        grid[i][j] = 0;
        sum += Dfs(grid, i - 1, j);
        sum += Dfs(grid, i + 1, j);
        sum += Dfs(grid, i, j - 1);
        sum += Dfs(grid, i, j + 1);
        return sum;

    }
}
// @lc code=end



/*
// @lcpr case=start
// [[0,0,1,0,0,0,0,1,0,0,0,0,0],[0,0,0,0,0,0,0,1,1,1,0,0,0],[0,1,1,0,1,0,0,0,0,0,0,0,0],[0,1,0,0,1,1,0,0,1,0,1,0,0],[0,1,0,0,1,1,0,0,1,1,1,0,0],[0,0,0,0,0,0,0,0,0,0,1,0,0],[0,0,0,0,0,0,0,1,1,1,0,0,0],[0,0,0,0,0,0,0,1,1,0,0,0,0]]\n
// @lcpr case=end

// @lcpr case=start
// [[0,0,0,0,0,0,0,0]]\n
// @lcpr case=end

 */

