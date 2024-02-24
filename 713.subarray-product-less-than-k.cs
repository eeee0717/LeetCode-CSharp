/*
 * @lc app=leetcode.cn id=713 lang=csharp
 * @lcpr version=30117
 *
 * [713] 乘积小于 K 的子数组
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        if(k < 2) return 0;
        int n = nums.Length, l = 0, r = 0, res = 0, sum = 1;
        while(r < n)
        {
            sum*=nums[r];
            while(sum>=k)
            {
                sum/=nums[l];
                l++;
            }
            r++;
            res += r - l;
        }
        
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [10,5,2,6]\n100\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3]\n0\n
// @lcpr case=end

 */

