/*
 * @lc app=leetcode.cn id=416 lang=csharp
 * @lcpr version=30113
 *
 * [416] 分割等和子集
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool CanPartition(int[] nums)
    {
        int sum = 0;
        int[] dp = new int[10001];
        foreach (int num in nums)
        {
            sum += num;
        }
        if (sum % 2 == 1) return false;
        int tartget = sum / 2;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = tartget; j >= nums[i]; j--)
            {
                dp[j] = Math.Max(dp[j], dp[j - nums[i]] + nums[i]);
            }
        }
        if (dp[tartget] == tartget)
            return true;

        return false;

    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,5,11,5]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,5]\n
// @lcpr case=end

 */

