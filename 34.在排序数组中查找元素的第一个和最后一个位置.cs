/*
 * @lc app=leetcode.cn id=34 lang=csharp
 *
 * [34] 在排序数组中查找元素的第一个和最后一个位置
 */

// @lc code=start
public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int leftBorder = GetLeftBorder(nums, target);
        int rightBorder = GetRightBorder(nums, target);
        if (leftBorder == -2 || rightBorder == -2) return new int[] { -1, -1 };
        if (rightBorder - leftBorder > 1) return new int[] { leftBorder + 1, rightBorder - 1 };
        return new int[] { -1, -1 };
    }
    public int GetLeftBorder(int[] nums, int target)
    {
        int l = 0;
        int r = nums.Length - 1;
        int leftBorder = -2;
        while (l <= r)
        {
            int mid = (l + r) / 2;
            if (nums[mid] >= target)
            {
                r = mid - 1;
                leftBorder = r;
            }
            else
                l = mid + 1;
        }
        return leftBorder;
    }
    public int GetRightBorder(int[] nums, int target)
    {
        int l = 0;
        int r = nums.Length - 1;
        int rightBorder = -2;
        while (l <= r)
        {
            int mid = (l + r) / 2;
            if (nums[mid] > target)
            {
                r = mid - 1;
            }
            else
            {
                l = mid + 1;
                rightBorder = l;
            }
        }
        return rightBorder;
    }
}
// @lc code=end

