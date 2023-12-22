/*
 * @lc app=leetcode.cn id=47 lang=csharp
 * @lcpr version=30112
 *
 * [47] 全排列 II
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public List<IList<int>> res = new List<IList<int>>();
    public List<int> path = new List<int>();
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        Array.Sort(nums);
        BackTracking(nums, new bool[nums.Length]);
        return res;
    }
    public void BackTracking(int[] nums, bool[] used)
    {
        if (nums.Length == path.Count)
        {
            res.Add(new List<int>(path));
            return;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1] && used[i - 1] == false) continue;
            if (used[i]) continue;
            path.Add(nums[i]);
            used[i] = true;
            BackTracking(nums, used);
            path.RemoveAt(path.Count - 1);
            used[i] = false;
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,1,2]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3]\n
// @lcpr case=end

 */

