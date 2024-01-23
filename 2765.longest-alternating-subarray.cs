/*
 * @lc app=leetcode.cn id=2765 lang=csharp
 * @lcpr version=30113
 *
 * [2765] 最长交替子序列
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int AlternatingSubarray(int[] nums)
    {
        int res = 0;
        for (int L = 0; L < nums.Length - 1; L++)
        {
            int R = L + 1;
            int pre = nums[R] - nums[L];
            if (pre != 1) continue;
            while (R + 1< nums.Length && nums[R + 1] - nums[R] == -pre)
            {
                R++;
                pre = -pre;
            }
            res = Math.Max(res, R - L + 1);
        }
        return res == 0 ? -1 : res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,3,4,3,4]\n
// @lcpr case=end

// @lcpr case=start
// [4,5,6]\n
// @lcpr case=end

 */

