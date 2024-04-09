/*
 * @lc app=leetcode.cn id=647 lang=csharp
 * @lcpr version=30121
 *
 * [647] 回文子串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CountSubstrings(string s)
    {
        int n = s.Length, ans = n;
        for (int i = 0; i < n; i++)
        {
            int l = i - 1, r = i + 1;
            while (l >= 0 && r < n)
            {
                if (s[l--] == s[r++]) ans++;
                else break;
            }
        }
        for (int i = 0; i < n - 1; i++)
        {
            if (s[i] == s[i + 1])
            {
                ans++;
                int l = i - 1, r = i + 2;
                while (l >= 0 && r < n)
                {
                    if (s[l--] == s[r++]) ans++;
                    else break;
                }
            }
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "abc"\n
// @lcpr case=end

// @lcpr case=start
// "aaa"\n
// @lcpr case=end

 */

