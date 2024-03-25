/*
 * @lc app=leetcode.cn id=139 lang=csharp
 * @lcpr version=30120
 *
 * [139] 单词拆分
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        HashSet<string> hs = new HashSet<string>(wordDict);
        bool[] valid = new bool[s.Length + 1];
        valid[0] = true;
        for(int i = 1; i <=s.Length; i++)
        {
            for(int j = 0; j < i && !valid[i] ;j++)
            {
                if(hs.Contains(s.Substring(j, i-j)) && valid[j])
                 valid[i] = true;
            }
        }
        return valid[s.Length];
    }
}
// @lc code=end



/*
// @lcpr case=start
// "leetcode"\n["leet", "code"]\n
// @lcpr case=end

// @lcpr case=start
// "applepenapple"\n["apple", "pen"]\n
// @lcpr case=end

// @lcpr case=start
// "catsandog"\n["cats", "dog", "sand", "and", "cat"]\n
// @lcpr case=end

 */

