/*
 * @lc app=leetcode.cn id=53 lang=csharp
 * @lcpr version=30112
 *
 * [53] 最大子数组和
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int res = Int32.MinValue;
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            count += nums[i];
            res = Math.Max(res, count);
            if (count < 0) count = 0;
        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [-2,1,-3,4,-1,2,1,-5,4]\n
// @lcpr case=end

// @lcpr case=start
// [1]\n
// @lcpr case=end

// @lcpr case=start
// [5,4,-1,7,8]\n
// @lcpr case=end

 */

