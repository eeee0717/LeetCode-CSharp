/*
 * @lc app=leetcode.cn id=459 lang=csharp
 * @lcpr version=30105
 *
 * [459] 重复的子字符串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool RepeatedSubstringPattern(string s)
    {
        if (s.Length == 0)
            return false;
        int[] next = GetNext(s);
        int len = s.Length;
        if (next[len - 1] != 0 && len % (len - next[len - 1]) == 0) return true;
        return false;
    }
    public int[] GetNext(string s)
    {
        int[] next = Enumerable.Repeat(0, s.Length).ToArray();
        for (int i = 1, j = 0; i < s.Length; i++)
        {
            while (j > 0 && s[i] != s[j])
                j = next[j - 1];
            if (s[i] == s[j])
                j++;
            next[i] = j;
        }
        return next;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "abab"\n
// @lcpr case=end

// @lcpr case=start
// "aba"\n
// @lcpr case=end

// @lcpr case=start
// "abcabcabcabc"\n
// @lcpr case=end

 */

