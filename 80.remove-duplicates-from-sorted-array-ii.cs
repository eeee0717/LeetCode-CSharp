/*
 * @lc app=leetcode.cn id=80 lang=csharp
 * @lcpr version=30114
 *
 * [80] 删除有序数组中的重复项 II
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int n = nums.Length;
        if (n <= 2) return n;
        int slow = 2, fast = 2;
        while (fast < n)
        {
            if (nums[slow - 2] != nums[fast]) nums[slow++] = nums[fast];
            fast++;
        }
        return slow;

    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,1,1,2,2,3]\n
// @lcpr case=end

// @lcpr case=start
// [0,0,1,1,1,1,2,3,3]\n
// @lcpr case=end

 */

