/*
 * @lc app=leetcode.cn id=3 lang=csharp
 *
 * [3] 无重复字符的最长子串
 */

// @lc code=start
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int slow = 0;
        int len = 0;
        for (int fast = slow+1; fast < s.Length; fast++)
        {
            if(s[slow]==s[fast])
            {
                len = fast - slow++;
            }
        }
        return len;
    }
}
// @lc code=end

