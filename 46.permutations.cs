/*
 * @lc app=leetcode.cn id=46 lang=csharp
 * @lcpr version=30112
 *
 * [46] 全排列
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public IList<IList<int>> res = new List<IList<int>>();
    public IList<int> path = new List<int>();
    public IList<IList<int>> Permute(int[] nums)
    {
        var used = new bool[nums.Length];
        BackTracking(nums, used);
        return res;
    }
    public void BackTracking(int[] nums, bool[] used)
    {
        if (path.Count == nums.Length)
        {
            res.Add(new List<int>(path));
            return;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (used[i]) continue;
            used[i] = true;
            path.Add(nums[i]);
            BackTracking(nums, used);
            used[i] = false;
            path.RemoveAt(path.Count - 1);
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3]\n
// @lcpr case=end

// @lcpr case=start
// [0,1]\n
// @lcpr case=end

// @lcpr case=start
// [1]\n
// @lcpr case=end

 */

