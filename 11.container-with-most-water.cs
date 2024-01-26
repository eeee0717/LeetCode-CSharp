/*
 * @lc app=leetcode.cn id=11 lang=csharp
 * @lcpr version=30113
 *
 * [11] 盛最多水的容器
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int res = 0;
        int current = 0;
        while (left != right)
        {
            if (height[left] <= height[right])
            {
                current = (right - left) * height[left];
                left++;
            }
            else
            {
                current = (right - left) * height[right];
                right--;
            }
            res = res < current ? current : res;
        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,8,6,2,5,4,8,3,7]\n
// @lcpr case=end

// @lcpr case=start
// [1,1]\n
// @lcpr case=end

 */

