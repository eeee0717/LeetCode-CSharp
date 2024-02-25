/*
 * @lc app=leetcode.cn id=424 lang=csharp
 * @lcpr version=30117
 *
 * [424] 替换后的最长重复字符
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int[] cnt = new int[26];
        char[] chs = s.ToCharArray();
        int l = 0, r = 0, maxCnt = 0;
        for (r = 0; r < chs.Length; r++)
        {
            cnt[chs[r] - 'A']++;
            maxCnt = Math.Max(maxCnt, cnt[chs[r] - 'A']);
            if (r - l + 1 > maxCnt + k)
            {
                cnt[chs[l] - 'A']--;
                l++;
            }
        }
        return chs.Length - l;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "ABAB"\n2\n
// @lcpr case=end

// @lcpr case=start
// "AABABBA"\n1\n
// @lcpr case=end

 */

