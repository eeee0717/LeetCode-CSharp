/*
 * @lc app=leetcode.cn id=541 lang=csharp
 *
 * [541] 反转字符串 II
 */

// @lc code=start
public class Solution
{
    public string ReverseStr(string s, int k)
    {
        char[] sChar = s.ToCharArray();
        for (int i = 0; i < s.Length; i += 2 * k)
        {
            Reverse(sChar, i, Math.Min(i + k, s.Length) - 1);
        }
        return new string(sChar);
    }
    public void Reverse(char[] arr, int l, int r)
    {
        while (l < r)
            (arr[l], arr[r]) = (arr[r--], arr[l++]);
    }
}
// @lc code=end

