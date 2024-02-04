/*
 * @lc app=leetcode.cn id=1004 lang=csharp
 * @lcpr version=30114
 *
 * [1004] 最大连续1的个数 III
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int l = 0, r = 0;
        int n = nums.Length;
        while(r < n)
        {
            if(nums[r++] == 0)k--;
            if(k < 0 && nums[l++]==0)k++;
        }
        return r - l;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,1,1,0,0,0,1,1,1,1,0]\n2\n
// @lcpr case=end

// @lcpr case=start
// [0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1]\n3\n
// @lcpr case=end

 */

