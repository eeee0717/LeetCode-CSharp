/*
 * @lc app=leetcode.cn id=151 lang=csharp
 *
 * [151] 反转字符串中的单词
 */

// @lc code=start
public class Solution {
    public string ReverseWords(string s) {
        return string.Join(' ', s.Trim().Split(' ',StringSplitOptions.RemoveEmptyEntries).Reverse());
    }
}
// @lc code=end

