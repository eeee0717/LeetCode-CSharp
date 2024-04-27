/*
 * @lc app=leetcode.cn id=153 lang=csharp
 * @lcpr version=30122
 *
 * [153] 寻找旋转排序数组中的最小值
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution {
    public int FindMin(int[] nums) {
        int low = 0, high = nums.Length - 1;
        while(low < high)
        {
            int pivot = low + (high - low) / 2;
            if(nums[pivot] < nums[high])
            {
                high = pivot;
            }
            else
            {
                low = pivot + 1;
            }
        }
        return nums[low];
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,4,5,1,2]\n
// @lcpr case=end

// @lcpr case=start
// [4,5,6,7,0,1,2]\n
// @lcpr case=end

// @lcpr case=start
// [11,13,15,17]\n
// @lcpr case=end

 */

