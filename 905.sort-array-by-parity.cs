/*
 * @lc app=leetcode.cn id=905 lang=csharp
 * @lcpr version=30122
 *
 * [905] 按奇偶排序数组
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {
        int left = 0, right = nums.Length - 1;
        while (left < right)
        {
            while (left < right && nums[left] % 2 == 0)
            {
                left++;
            }
            while (left < right && nums[right] % 2 == 1)
            {
                right--;
            }
            if (left < right)
            {
                (nums[left], nums[right]) = (nums[right], nums[left]);
                left++;
                right--;
            }

        }
        return nums;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,1,2,4]\n
// @lcpr case=end

// @lcpr case=start
// [0]\n
// @lcpr case=end

 */

