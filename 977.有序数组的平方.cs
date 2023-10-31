/*
 * @lc app=leetcode.cn id=977 lang=csharp
 *
 * [977] 有序数组的平方
 */

// @lc code=start
public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int l = 0;
        int r = nums.Length - 1;
        int[] res = new int[nums.Length];
        for (int i = nums.Length - 1; i >=0; i--)
        {
            int lx = nums[l] * nums[l];
            int rx = nums[r] * nums[r];
            if (lx >= rx)
            {
                res[i] = lx;
                l++;
            }
            else
            {
                res[i] = rx;
                r--;
            }
        }
        return res;

    }
}
// @lc code=end

