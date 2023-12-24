/*
 * @lc app=leetcode.cn id=37 lang=csharp
 * @lcpr version=30112
 *
 * [37] 解数独
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public void SolveSudoku(char[][] board)
    {
        BackTracking(board);
    }
    public bool BackTracking(char[][] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] != '.') continue;
                for (char k = '1'; k <= '9'; k++)
                {
                    if (IsValid(board, i, j, k))
                    {
                        board[i][j] = k;
                        if (BackTracking(board)) return true;
                        board[i][j] = '.';
                    }
                }
                return false;
            }

        }
        return true;
    }
    public bool IsValid(char[][] board, int row, int col, char val)
    {
        for (int i = 0; i < 9; i++)
        {
            if (board[i][col] == val) return false;
        }
        for (int i = 0; i < 9; i++)
        {
            if (board[row][i] == val) return false;
        }
        int startRow = (row / 3) * 3;
        int startCol = (col / 3) * 3;
        for (int i = startRow; i < startRow + 3; i++)
        {
            for (int j = startCol; j < startCol + 3; j++)
            {
                if (board[i][j] == val) return false;
            }
        }
        return true;
    }
}

// @lc code=end



/*
// @lcpr case=start
// [["5","3",".",".","7",".",".",".","."],["6",".",".","1","9","5",".",".","."],[".","9","8",".",".",".",".","6","."],["8",".",".",".","6",".",".",".","3"],["4",".",".","8",".","3",".",".","1"],["7",".",".",".","2",".",".",".","6"],[".","6",".",".",".",".","2","8","."],[".",".",".","4","1","9",".",".","5"],[".",".",".",".","8",".",".","7","9"]]\n
// @lcpr case=end

 */

