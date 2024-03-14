/*
 * @lc app=leetcode.cn id=5 lang=csharp
 * @lcpr version=30119
 *
 * [5] 最长回文子串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string LongestPalindrome(string s)
    {
        var res = "";
        var n = s.Length;
        var end = 2 * n - 1;
        for(int i = 0; i < end; i++)
        {
            var mid = i / 2.0;
            var p = (int)Math.Floor(mid);
            var q = (int)Math.Ceiling(mid);
            while(p >=0 && q < n)
            {
                if(s[q] != s[p]) break;
                p--;
                q++;
            }
            int len = q - p - 1;
            if(len > res.Length)
            {
                res = s.Substring(p+1, len);
            }
        }
        return res;

    }

}
// @lc code=end



/*
// @lcpr case=start
// "babad"\n
// @lcpr case=end

// @lcpr case=start
// "cbbd"\n
// @lcpr case=end

 */

