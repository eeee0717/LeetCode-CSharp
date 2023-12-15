/*
 * @lc app=leetcode.cn id=40 lang=csharp
 * @lcpr version=30111
 *
 * [40] 组合总和 II
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public List<IList<int>> res = new List<IList<int>>();
    public List<int> path = new List<int>();
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {

        Array.Sort(candidates);
        BackTracking(candidates, target, 0, 0);
        return res;
    }
    public void BackTracking(int[] candidates, int target, int start, int sum)
    {
        if (sum > target) return;
        if (sum == target)
        {
            res.Add(new List<int>(path));
            return;
        }
        for (int i = start; i < candidates.Length && sum + candidates[i] <= target; i++)
        {
            if (i > start && candidates[i] == candidates[i - 1]) continue;
            sum += candidates[i];
            path.Add(candidates[i]);
            BackTracking(candidates, target, i + 1, sum);
            sum -= candidates[i];
            path.RemoveAt(path.Count - 1);
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// [10,1,2,7,6,1,5]\n8,\n
// @lcpr case=end

// @lcpr case=start
// [2,5,2,1,2]\n5,\n
// @lcpr case=end

 */

