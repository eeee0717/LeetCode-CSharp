/*
 * @lc app=leetcode.cn id=189 lang=csharp
 * @lcpr version=30122
 *
 * [189] 轮转数组
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k %= n;
        Array.Reverse(nums, 0, n);  
        Array.Reverse(nums, 0, k);
        Array.Reverse(nums, k, n - k);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,4,5,6,7]\n3\n
// @lcpr case=end

// @lcpr case=start
// [-1,-100,3,99]\n2\n
// @lcpr case=end

 */

