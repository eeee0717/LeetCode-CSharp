/*
 * @lc app=leetcode.cn id=567 lang=csharp
 * @lcpr version=30114
 *
 * [567] 字符串的排列
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        if(s1.Length > s2.Length) return false;
        var arr = new int[26];
        var n = s1.Length;
        for (int i = 0; i < n; i++)
        {
            arr[s1[i] - 'a']--;
            arr[s2[i] - 'a']++;
        }
        if (!arr.Any(e => e != 0)) return true;
        for (int i = n; i < s2.Length; i++)
        {
            arr[s2[i - n] - 'a']--;
            arr[s2[i] - 'a']++;
            if (!arr.Any(e => e != 0)) return true;
        }
        return false;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "eidbaooo"\n
// @lcpr case=end

// @lcpr case=start
// "eidboaoo"\n
// @lcpr case=end

 */

