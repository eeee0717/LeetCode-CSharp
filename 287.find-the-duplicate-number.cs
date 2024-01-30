/*
 * @lc app=leetcode.cn id=287 lang=csharp
 * @lcpr version=30114
 *
 * [287] 寻找重复数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int FindDuplicate(int[] nums)
    {
        int fast = 0, slow = 0;
        int meet = -1;
        while (meet < 0)
        {
            fast = nums[nums[fast]];
            slow = nums[slow];
            if (fast == slow) meet = fast;
        }
        int p1 = 0, p2 = meet;
        while (p1 != p2)
        {
            p1 = nums[p1];
            p2 = nums[p2];
        }
        return p1;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,3,4,2,2]\n
// @lcpr case=end

// @lcpr case=start
// [3,1,3,4,2]\n
// @lcpr case=end

 */

