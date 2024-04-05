/*
 * @lc app=leetcode.cn id=79 lang=csharp
 * @lcpr version=30121
 *
 * [79] 单词搜索
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    int[][] direction = new int[][] { new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { 0, 1 }, new int[] { -1, 0 } };


    public bool Exist(char[][] board, string word)
    {
        var tmp = string.Empty;
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                var vis = new bool[board.Length, board[0].Length];
                if (DFS(board, word, vis, i, j, tmp))
                    return true;
            }
        }
        return false;

    }
    public bool DFS(char[][] board, string word, bool[,] vis, int i, int j, string tmp)
    {
        if (i < 0 || i == board.Length || j < 0 || j == board[0].Length || word[tmp.Length] != board[i][j] || vis[i, j])
            return false;

        tmp += board[i][j];
        vis[i, j] = true;
        if (tmp.Length == word.Length) return true;
        for (int k = 0; k < direction.Length; k++)
        {
            if (DFS(board, word, vis, i + direction[k][0], j + direction[k][1], tmp)) return true;
        }
        vis[i,j] = false;
        return false;

    }
}
// @lc code=end



/*
// @lcpr case=start
// [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]]\n"ABCCED"\n
// @lcpr case=end

// @lcpr case=start
// [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]]\n"SEE"\n
// @lcpr case=end

// @lcpr case=start
// [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]]\n"ABCB"\n
// @lcpr case=end

 */

