/*
 * @lc app=leetcode.cn id=1005 lang=csharp
 * @lcpr version=30112
 *
 * [1005] K 次取反后最大化的数组和
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int LargestSumAfterKNegations(int[] nums, int k)
    {
        int res = 0;
        Array.Sort(nums, (a, b) => Math.Abs(b) - Math.Abs(a));
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < 0 && k > 0)
            {
                nums[i] *= -1;
                k--;
            }
        }
        if (k % 2 == 1) nums[nums.Length - 1] *= -1;
        foreach (var item in nums) res += item;
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [4,2,3]\n1\n
// @lcpr case=end

// @lcpr case=start
// [3,-1,0,2]\n3\n
// @lcpr case=end

// @lcpr case=start
// [2,-3,-1,5,-4]\n2\n
// @lcpr case=end

 */

