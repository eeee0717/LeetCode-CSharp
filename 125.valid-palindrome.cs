/*
 * @lc app=leetcode.cn id=125 lang=csharp
 * @lcpr version=30116
 *
 * [125] 验证回文串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool IsPalindrome(string s)
    {
        int n = s.Length;
        var charList = new List<char>();
        for (int i = 0; i < n; i++)
        {
            if (Char.IsLetterOrDigit(s[i])) charList.Add(s[i]);
        }
        int l = 0, r = charList.Count - 1;
        while (l < r)
        {
            if (Char.ToLower(charList[l]) != Char.ToLower(charList[r])) return false;
            l++;
            r--;
        }
        return true;

    }
}
// @lc code=end



/*
// @lcpr case=start
// "A man, a plan, a canal: Panama"\n
// @lcpr case=end

// @lcpr case=start
// "race a car"\n
// @lcpr case=end

// @lcpr case=start
// " "\n
// @lcpr case=end

 */

