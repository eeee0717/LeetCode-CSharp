/*
 * @lc app=leetcode.cn id=930 lang=csharp
 * @lcpr version=30117
 *
 * [930] 和相同的二元子数组
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int NumSubarraysWithSum(int[] nums, int goal)
    {
        int res = 0;
        int l1 = 0, l2 = 0, r = 0;
        int sum1 = 0, sum2 = 0;
        while (r < nums.Length)
        {
            sum1 += nums[r];
            while (l1 <= r && sum1 > goal)
            {
                sum1 -= nums[l1++];
            }
            sum2 += nums[r];
            while (l2 <= r && sum2 >= goal)
            {
                sum2 -= nums[l2++];
            }
            res += (l2 - l1);
            r++;
        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,0,1,0,1]\n2\n
// @lcpr case=end

// @lcpr case=start
// [0,0,0,0,0]\n0\n
// @lcpr case=end

 */

