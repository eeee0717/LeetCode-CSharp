/*
 * @lc app=leetcode.cn id=376 lang=csharp
 * @lcpr version=30112
 *∑∑
 * [376] 摆动序列
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int WiggleMaxLength(int[] nums)
    {
        if (nums.Length < 2) return nums.Length;
        int curDiff = 0, preDiff = 0, res = 1;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            curDiff = nums[i + 1] - nums[i];
            if ((curDiff > 0 && preDiff <= 0) || (curDiff < 0 && preDiff >= 0))
            {
                res++;
                preDiff = curDiff;
            }
        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,7,4,9,2,5]\n
// @lcpr case=end

// @lcpr case=start
// [1,17,5,10,13,15,10,5,16,8]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,4,5,6,7,8,9]\n
// @lcpr case=end

 */

