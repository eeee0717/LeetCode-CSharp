/*
 * @lc app=leetcode.cn id=90 lang=csharp
 * @lcpr version=30112
 *
 * [90] 子集 II
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public IList<IList<int>> res = new List<IList<int>>();
    public IList<int> path = new List<int>();
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums);
        BackTracking(nums, 0);
        return res;
    }
    public void BackTracking(int[] nums, int start)
    {
        res.Add(new List<int>(path));
        for (int i = start; i < nums.Length; i++)
        {
            if (i > start && nums[i] == nums[i - 1]) continue;
            path.Add(nums[i]);
            BackTracking(nums, i + 1);
            path.RemoveAt(path.Count - 1);
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,2]\n
// @lcpr case=end

// @lcpr case=start
// [0]\n
// @lcpr case=end

 */

