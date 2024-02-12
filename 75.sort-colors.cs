/*
 * @lc app=leetcode.cn id=75 lang=csharp
 * @lcpr version=30116
 *
 * [75] 颜色分类
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public void SortColors(int[] nums)
    {
        int n = nums.Length;
        int left = 0, right = n - 1;
        for (int i = 0; i <= right; i++)
        {
            if (nums[i] == 0)
            {
                (nums[i], nums[left]) = (nums[left], nums[i]);
                left++;
            }
            if (nums[i] == 2)
            {
                (nums[i], nums[right]) = (nums[right], nums[i]);
                right--;
                if (nums[i] != 1)
                {
                    i--;
                }
            }
        }
        return;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,0,2,1,1,0]\n
// @lcpr case=end

// @lcpr case=start
// [2,0,1]\n
// @lcpr case=end

 */

