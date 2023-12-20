/*
 * @lc app=leetcode.cn id=491 lang=csharp
 * @lcpr version=30112
 *
 * [491] 递增子序列
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution {
    public IList<IList<int>> res = new List<IList<int>>();
    public IList<int> path = new List<int>();
    public IList<IList<int>> FindSubsequences(int[] nums) {
        BackTracking(nums, 0);
        return res;
    }
    public void BackTracking(int[] nums, int start){
        if(path.Count >= 2){
            res.Add(new List<int>(path));
        }
        HashSet<int> hs = new HashSet<int>();
        for(int i = start; i < nums.Length; i++){
            if(path.Count > 0 && path[path.Count - 1] > nums[i] || hs.Contains(nums[i])){
                continue;
            }
            hs.Add(nums[i]);
            path.Add(nums[i]);
            BackTracking(nums, i + 1);
            path.RemoveAt(path.Count - 1);
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// [4,6,7,7]\n
// @lcpr case=end

// @lcpr case=start
// [4,4,3,2,1]\n
// @lcpr case=end

 */

