/*
 * @lc app=leetcode.cn id=216 lang=csharp
 * @lcpr version=30111
 *
 * [216] 组合总和 III
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public IList<IList<int>> res = new List<IList<int>>();
    public IList<int> path = new List<int>();
    public IList<IList<int>> CombinationSum3(int k, int n)
    {
        BackTracking(k, n, 0, 1);
        return res;
    }
    public void BackTracking(int k, int n, int sum, int start)
    {
        if (sum > n)
            return;
        if (path.Count == k)
        {
            if (sum == n)
                res.Add(new List<int>(path));
            return;
        }
        for (int i = start; i <= 9 - (k - path.Count) + 1; i++)
        {
            sum += i;
            path.Add(i);
            BackTracking(k, n, sum, i + 1);
            sum -= i;
            path.RemoveAt(path.Count - 1);
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// 3\n7\n
// @lcpr case=end

// @lcpr case=start
// 3\n9\n
// @lcpr case=end

// @lcpr case=start
// 4\n1\n
// @lcpr case=end

 */

