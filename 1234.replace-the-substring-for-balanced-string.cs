/*
 * @lc app=leetcode.cn id=1234 lang=csharp
 * @lcpr version=30117
 *
 * [1234] 替换子串得到平衡字符串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution {
    public int BalancedString(string s) {
        int[] cnt = new int[26];
        foreach (var c in s)
        {
            cnt[c - 'A']++;
        }
        int p = s.Length / 4;
        int res = s.Length;
        for(int l = 0, r = 0; l < s.Length; l++){
            while(r < s.Length && !Check(cnt, p))
            {
                cnt[s[r] - 'A']--;
                r++;
            }
            if(!Check(cnt, p))
            {
                break;
            }
            res = Math.Min(res, r - l);
            cnt[s[l] - 'A']++;
        }
        return res;
    }
    public bool Check(int[] cnt, int p)
    {
        if(cnt['Q'-'A'] > p || cnt['W'-'A'] > p || cnt['E'-'A'] > p || cnt['R'-'A'] > p)
        {
            return false;
        }
        return true;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "QWER"\n
// @lcpr case=end

// @lcpr case=start
// "QQWE"\n
// @lcpr case=end

// @lcpr case=start
// "QQQW"\n
// @lcpr case=end

// @lcpr case=start
// "QQQQ"\n
// @lcpr case=end

 */

