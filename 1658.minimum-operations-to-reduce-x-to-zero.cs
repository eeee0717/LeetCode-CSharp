/*
 * @lc app=leetcode.cn id=1658 lang=csharp
 * @lcpr version=30116
 *
 * [1658] 将 x 减到 0 的最小操作数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MinOperations(int[] nums, int x)
    {
        int target = -x;
        foreach (var num in nums)
        {
            target += num;
        }
        if (target < 0) return -1;
        int l = 0, n = nums.Length, sum = 0, ans = -1;
        for(int r = 0; r < n; r++)
        {
            sum+= nums[r];
            while(sum > target) sum-=nums[l++];
            if(sum == target) ans = Math.Max(ans, r - l + 1);
        }
        return ans == -1 ? -1 : n - ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,1,4,2,3]\n5\n
// @lcpr case=end

// @lcpr case=start
// [5,6,7,8,9]\n4\n
// @lcpr case=end

// @lcpr case=start
// [3,2,20,1,1,3]\n10\n
// @lcpr case=end

 */

