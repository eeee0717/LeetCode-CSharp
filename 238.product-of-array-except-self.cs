/*
 * @lc app=leetcode.cn id=238 lang=csharp
 * @lcpr version=30121
 *
 * [238] 除自身以外数组的乘积
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        if (n == 0) return new int[0];
        int[] ans = new int[n];
        ans[0] = 1;
        int tmp = 1;
        for (int i = 1; i < n; i++)
        {
            ans[i] = ans[i - 1] * nums[i - 1];
        }
        for (int i = n - 2; i >= 0; i--)
        {
            tmp *= nums[i + 1];
            ans[i] *= tmp;
        }
        return ans;


    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,4]\n
// @lcpr case=end

// @lcpr case=start
// [-1,1,0,-3,3]\n
// @lcpr case=end

 */

