/*
 * @lc app=leetcode.cn id=524 lang=csharp
 * @lcpr version=30117
 *
 * [524] 通过删除字母匹配到字典里最长单词
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string FindLongestWord(string s, IList<string> dictionary)
    {
        var res = "";
        int n = s.Length;
        foreach (var word in dictionary)
        {
            int m = word.Length;
            int p = 0, q = 0;
            while (p < n && q < m)
            {
                if (s[p] == word[q])
                {
                    q++;
                }
                p++;
            }
            if (q == m)
            {
                if (m > res.Length || (m == res.Length && word.CompareTo(res) < 0))
                {
                    res = word;
                }
            }
        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "abpcplea"\n["ale","apple","monkey","plea"]\n
// @lcpr case=end

// @lcpr case=start
// "abpcplea"\n["a","b","c"]\n
// @lcpr case=end

 */

