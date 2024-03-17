/*
 * @lc app=leetcode.cn id=31 lang=csharp
 * @lcpr version=30119
 *
 * [31] 下一个排列
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution {
    public void NextPermutation(int[] nums) {
        if(nums.Length <= 1) return;
        int i = nums.Length - 2;
        int j = nums.Length - 1;
        int k = nums.Length - 1;

        while(i>=0 && nums[i]>=nums[j])
        {
            i--;
            j--;
        }
        if(i>=0)
        {
            while(nums[i] >= nums[k])
            {
                k--;
            }
            (nums[i], nums[k]) = (nums[k], nums[i]);
        }
        for(i = j, j = nums.Length-1;i < j;i++,j--)
        {
            (nums[i],nums[j]) = (nums[j], nums[i]);
        }
        return;

    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3]\n
// @lcpr case=end

// @lcpr case=start
// [3,2,1]\n
// @lcpr case=end

// @lcpr case=start
// [1,1,5]\n
// @lcpr case=end

 */

