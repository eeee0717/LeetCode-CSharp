/*
 * @lc app=leetcode.cn id=209 lang=csharp
 *
 * [209] 长度最小的子数组
 */

// @lc code=start
public class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int res = int.MaxValue;
        int l = 0;
        int s = 0;
        for (int r = 0; r < nums.Length; r++)
        {
            s += nums[r];
            while (s >= target)
            {
               
                res = res > (r - l + 1) ? (r - l + 1) : res;
                 s -= nums[l++];

            }
        }
        return res == int.MaxValue ? 0 : res;
    }
}
// @lc code=end

