/*
 * @lc app=leetcode.cn id=131 lang=csharp
 * @lcpr version=30111
 *
 * [131] 分割回文串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public IList<IList<string>> res = new List<IList<string>>();
    public IList<string> path = new List<string>();
    public IList<IList<string>> Partition(string s)
    {
        BackTracking(s, 0);
        return res;
    }
    public void BackTracking(string s, int start)
    {
        if (start >= s.Length)
        {
            res.Add(new List<string>(path));
            return;
        }

        for (int i = start; i < s.Length; i++)
        {
            if (IsPalindrome(s, start, i))
            {
                path.Add(s.Substring(start, i - start + 1));
            }
            else
            {
                continue;
            }
            BackTracking(s, i + 1);
            path.RemoveAt(path.Count - 1);
        }
    }
    public bool IsPalindrome(string s, int start, int end)
    {
        for (int i = start, j = end; i < j; i++, j--)
        {
            if (s[i] != s[j])
                return false;
        }
        return true;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "aab"\n
// @lcpr case=end

// @lcpr case=start
// "a"\n
// @lcpr case=end

 */

