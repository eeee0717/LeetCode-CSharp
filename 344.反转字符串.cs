/*
 * @lc app=leetcode.cn id=344 lang=csharp
 *
 * [344] 反转字符串
 */

// @lc code=start
public class Solution
{
    public void ReverseString(char[] s)
    {
        for (int i = 0, j = s.Length - 1; i < s.Length / 2; i++, j--)
        {
            (s[i], s[j]) = (s[j], s[i]);
        }
    }
}
// @lc code=end

