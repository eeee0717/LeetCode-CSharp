/*
 * @lc app=leetcode.cn id=581 lang=csharp
 * @lcpr version=30121
 *
 * [581] 最短无序连续子数组
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int FindUnsortedSubarray(int[] nums)
    {
        int n = nums.Length;
        int max = nums[0], min = nums[n - 1];
        int end = -1, begin = 0;
        for (int i = 0; i < n; i++)
        {
            if (nums[i] < max)
            {
                end = i;
            }
            else
            {
                max = nums[i];
            }
            if (nums[n - i - 1] > min)
            {
                begin = n - i - 1;
            }
            else
            {
                min = nums[n - i - 1];
            }
        }
        return end - begin + 1;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,6,4,8,10,9,15]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,4]\n
// @lcpr case=end

// @lcpr case=start
// [1]\n
// @lcpr case=end

 */

