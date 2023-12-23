/*
 * @lc app=leetcode.cn id=51 lang=csharp
 * @lcpr version=30112
 *
 * [51] N 皇后
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public List<IList<string>> res = new();
    public IList<IList<string>> SolveNQueens(int n)
    {
        char[][] chessBoard = new char[n][];
        for (int i = 0; i < n; i++)
        {
            chessBoard[i] = new char[n];
            for (int j = 0; j < n; j++)
            {
                chessBoard[i][j] = '.';
            }
        }
        BackTracking(n, 0, chessBoard);
        return res;
    }
    public void BackTracking(int n, int row, char[][] chessBoard)
    {
        if (row == n)
        {
            res.Add(chessBoard.Select(x => new string(x)).ToList());
            return;
        }
        for (int col = 0; col < n; col++)
        {
            if (IsValid(row, col, chessBoard, n))
            {
                chessBoard[row][col] = 'Q';
                BackTracking(n, row + 1, chessBoard);
                chessBoard[row][col] = '.';
            }
        }
    }
    public bool IsValid(int row, int col, char[][] chessBoard, int n)
    {
        for (int i = 0; i < row; i++)
        {
            if (chessBoard[i][col] == 'Q') return false;
        }
        for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
        {
            if (chessBoard[i][j] == 'Q') return false;
        }
        for (int i = row - 1, j = col + 1; i >= 0 && j < n; i--, j++)
        {
            if (chessBoard[i][j] == 'Q') return false;
        }
        return true;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 4\n
// @lcpr case=end

// @lcpr case=start
// 1\n
// @lcpr case=end

 */

