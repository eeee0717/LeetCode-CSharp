/*
 * @lc app=leetcode.cn id=611 lang=csharp
 * @lcpr version=30122
 *
 * [611] 有效三角形的个数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int TriangleNumber(int[] nums)
    {
        int n = nums.Length;
        Array.Sort(nums);
        int ans = 0;
        for (int i = 0; i < n; i++)
        {
            int k = i;
            for (int j = i + 1; j < n; j++)
            {
                while (k + 1 < n && nums[k + 1] < nums[i] + nums[j])
                {
                    k++;
                }
                ans += Math.Max(k - j, 0);

            }
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,2,3,4]\n
// @lcpr case=end

// @lcpr case=start
// [4,2,3,4]\n
// @lcpr case=end

 */

