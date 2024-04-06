/*
 * @lc app=leetcode.cn id=136 lang=csharp
 * @lcpr version=30121
 *
 * [136] 只出现一次的数字
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int ans = nums[0];
        if (nums.Length > 1)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                ans ^= nums[i];
            }
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,2,1]\n
// @lcpr case=end

// @lcpr case=start
// [4,1,2,1,2]\n
// @lcpr case=end

// @lcpr case=start
// [1]\n
// @lcpr case=end

 */

