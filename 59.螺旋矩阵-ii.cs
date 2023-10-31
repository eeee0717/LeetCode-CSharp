/*
 * @lc app=leetcode.cn id=59 lang=csharp
 *
 * [59] 螺旋矩阵 II
 */

// @lc code=start
public class Solution
{
    public int[][] GenerateMatrix(int n)
    {
        int[][] res = new int[n][];
        for(int m = 0; m<n;m++)
        {
            res[m] = new int[n];
        }

        int loop = n / 2;
        int startx = 0;
        int starty = 0;
        int offset = 1;
        int i,j;
        int count = 1;
        while (loop > 0)
        {
            i = startx;
            j = starty;
            for(j = starty; j < n - offset; j++)
            {
                res[startx][j] = count++;
            }
            for(i = startx; i < n - offset; i++)
            {
                res[i][j] = count++;
            }
            for(; j > starty; j--)
            {
                res[i][j] = count++;
            }
            for(; i > startx; i--)
            {
                res[i][j] = count++;
            }
            startx++;
            starty++;
            offset++;
            loop--;
        }
        if(n%2!=0)
            res[n/2][n/2]=count;
        return res;
    }
    
}
// @lc code=end

