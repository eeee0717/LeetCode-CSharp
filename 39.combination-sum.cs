/*
 * @lc app=leetcode.cn id=39 lang=csharp
 * @lcpr version=30111
 *
 * [39] 组合总和
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public IList<IList<int>> res = new List<IList<int>>();
    public IList<int> path = new List<int>();
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
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
            sum += candidates[i];
            path.Add(candidates[i]);
            BackTracking(candidates, target, i, sum);
            sum -= candidates[i];
            path.RemoveAt(path.Count - 1);
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,3,6,7]\n7\n
// @lcpr case=end

// @lcpr case=start
// [2,3,5]\n8\n
// @lcpr case=end

// @lcpr case=start
// [2]\n1\n
// @lcpr case=end

 */

