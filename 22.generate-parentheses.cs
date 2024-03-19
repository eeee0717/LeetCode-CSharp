/*
 * @lc app=leetcode.cn id=22 lang=csharp
 * @lcpr version=30119
 *
 * [22] 括号生成
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    List<string> res = new List<string>();
    StringBuilder path = new StringBuilder();
    public IList<string>
    GenerateParenthesis(int n)
    {

        BackTracking(0, 0, n);
        return res;
    }
    public void BackTracking(int l, int r, int n)
    {
        if (l > n || l < r) return;
        if (path.Length == 2 * n)
        {
            res.Add(path.ToString());
        }
        for (int i = 0; i < 2; i++)
        {
            if (i == 0)
            {
                path.Append('(');
                BackTracking(l + 1, r, n);
                path.Remove(path.Length - 1, 1);
            }
            else if (i == 1)
            {
                path.Append(')');
                BackTracking(l, r + 1, n);
                path.Remove(path.Length - 1, 1);
            }
        }


    }
}
// @lc code=end



/*
// @lcpr case=start
// 3\n
// @lcpr case=end

// @lcpr case=start
// 1\n
// @lcpr case=end

 */

