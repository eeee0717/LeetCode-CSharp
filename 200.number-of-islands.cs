/*
 * @lc app=leetcode.cn id=200 lang=csharp
 * @lcpr version=30120
 *
 * [200] 岛屿数量
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int NumIslands(char[][] grid)
    {
        int count = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    Dfs(grid, i, j);
                    count++;
                }
            }
        }
        return count;
    }
    public void Dfs(char[][] grid, int i, int j)
    {
        if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length || grid[i][j] == '0')return;
        grid[i][j] = '0';
        Dfs(grid, i + 1, j);
        Dfs(grid, i - 1, j);
        Dfs(grid, i, j + 1);
        Dfs(grid, i, j - 1);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [["1","1","1","1","0"],["1","1","0","1","0"],["1","1","0","0","0"],["0","0","0","0","0"]]\n
// @lcpr case=end

// @lcpr case=start
// [["1","1","0","0","0"],["1","1","0","0","0"],["0","0","1","0","0"],["0","0","0","1","1"]]\n
// @lcpr case=end

 */

