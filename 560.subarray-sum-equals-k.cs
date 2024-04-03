/*
 * @lc app=leetcode.cn id=560 lang=csharp
 * @lcpr version=30121
 *
 * [560] 和为 K 的子数组
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        int subarrays = 0;
        IDictionary<int, int> counts = new Dictionary<int, int>();
        counts.Add(0, 1);
        int sum = 0;
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            sum += nums[i];
            int count = counts.ContainsKey(sum - k) ? counts[sum - k] : 0;
            subarrays += count;
            counts.TryAdd(sum, 0);
            counts[sum]++;
        }
        return subarrays;

    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,1,1]\n2\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3]\n3\n
// @lcpr case=end

 */

