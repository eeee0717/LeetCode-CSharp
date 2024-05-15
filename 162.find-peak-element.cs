/*
 * @lc app=leetcode.cn id=162 lang=csharp
 * @lcpr version=30202
 *
 * [162] 寻找峰值
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int FindPeakElement(int[] nums)
    {
        int l = 0, r = nums.Length - 1;
        while (l < r)
        {
            int mid = l + (r - l) / 2;
            if (nums[mid] > nums[mid + 1])
            {
                r = mid;
            }
            else
            {
                l = mid + 1;
            }
        }
        return l;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,1]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,1,3,5,6,4]\n
// @lcpr case=end

 */

