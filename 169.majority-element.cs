/*
 * @lc app=leetcode.cn id=169 lang=csharp
 * @lcpr version=30119
 *
 * [169] 多数元素
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int vote = 0;
        int x = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (vote == 0) x = nums[i];
            vote = x == nums[i] ? vote + 1 : vote - 1;
        }
        return x;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,2,3]\n
// @lcpr case=end

// @lcpr case=start
// [2,2,1,1,1,2,2]\n
// @lcpr case=end

 */

