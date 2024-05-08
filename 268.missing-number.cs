/*
 * @lc app=leetcode.cn id=268 lang=csharp
 * @lcpr version=30201
 *
 * [268] 丢失的数字
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MissingNumber(int[] nums)
    {
        Array.Sort(nums);
        int l = 0, r = nums.Length-1;
        int ans = 1;
        while (l < r)
        {
            int mid = l + (r - l) / 2+1;
            if (nums[mid] > mid)
            {
                r = mid - 1;
            }
            else
            {
                l = mid;
            }
            ans = l + 1;
        }
        if (l == 0 && nums[l] == 1) return 0;
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,0,1]\n
// @lcpr case=end

// @lcpr case=start
// [0,1]\n
// @lcpr case=end

// @lcpr case=start
// [9,6,4,2,3,5,7,0,1]\n
// @lcpr case=end

// @lcpr case=start
// [0]\n
// @lcpr case=end

 */

