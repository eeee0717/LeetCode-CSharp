/*
 * @lc app=leetcode.cn id=77 lang=csharp
 * @lcpr version=30111
 *
 * [77] 组合
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public IList<IList<int>> res = new List<IList<int>>();
    public IList<int> path = new List<int>();
    public IList<IList<int>> Combine(int n, int k)
    {
        BackTracking(n, k, 1);
        return res;
    }
    public void BackTracking(int n, int k, int start)
    {
        if (path.Count == k)
        {
            res.Add(new List<int>(path));
            return;
        }
        for (int i = start; i <= n - (k - path.Count) + 1; i++)
        {
            path.Add(i);
            BackTracking(n, k, i + 1);
            path.RemoveAt(path.Count - 1);
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// 4\n2\n
// @lcpr case=end

// @lcpr case=start
// 1\n1\n
// @lcpr case=end

 */

