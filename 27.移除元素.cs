/*
 * @lc app=leetcode.cn id=27 lang=csharp
 *
 * [27] 移除元素
 */

// @lc code=start
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int slow = 0;
        for (int fast = slow; fast < nums.Length; fast++)
        {
            if(nums[fast] != val) nums[slow++] = nums[fast];
        }
        return slow;
    }
}
// @lc code=end

