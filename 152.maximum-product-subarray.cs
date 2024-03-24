/*
 * @lc app=leetcode.cn id=152 lang=csharp
 * @lcpr version=30120
 *
 * [152] 乘积最大子数组
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaxProduct(int[] nums)
    {
        int max = int.MinValue;
        int imax = 1, imin = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < 0)
            {
                (imax, imin) = (imin, imax);
            }
            imax = Math.Max(imax * nums[i], nums[i]);
            imin = Math.Min(imin * nums[i], nums[i]);
            max = Math.Max(max, imax);
        }
        return max;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,3,-2,4]\n
// @lcpr case=end

// @lcpr case=start
// [-2,0,-1]\n
// @lcpr case=end

 */

