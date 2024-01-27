/*
 * @lc app=leetcode.cn id=3 lang=csharp
 * @lcpr version=30113
 *
 * [3] 无重复字符的最长子串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length < 2) return s.Length;
        int left = 0;
        int right = 0;
        int res = 0;

        var hash = new HashSet<char>();

        while(right < s.Length)
        {
            if(!hash.Contains(s[right]))
            {
                hash.Add(s[right++]);
                res = Math.Max(res, right - left);
            }
            else
            {
                hash.Remove(s[left++]);
            }
        }
        return res;
      
    }
}
// @lc code=end



/*
// @lcpr case=start
// "abcabcbb"\n
// @lcpr case=end

// @lcpr case=start
// "bbbbb"\n
// @lcpr case=end

// @lcpr case=start
// "pwwkew"\n
// @lcpr case=end

 */

