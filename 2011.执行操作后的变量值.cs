/*
 * @lc app=leetcode.cn id=2011 lang=csharp
 *
 * [2011] 执行操作后的变量值
 */

// @lc code=start
public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int x = 0;
        foreach (var operation in operations)
        {
            if(operation.Contains("+"))
            {
                x++;
            }
            else if(operation.Contains("-"))
            {
                x--;
            }
        }
        return x;
    }
}
// @lc code=end

