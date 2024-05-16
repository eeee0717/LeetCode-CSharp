/*
 * @lc app=leetcode.cn id=260 lang=csharp
 * @lcpr version=30202
 *
 * [260] 只出现一次的数字 III
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] SingleNumber(int[] nums)
    {
        int xor = 0;
        foreach (var num in nums)
        {
            xor ^= num;
        }
        int[] ans = new int[2] { 0, 0 };
        int mask = (xor == int.MinValue ? xor : xor & (-xor));
        foreach (var num in nums)
        {
            if ((num & mask) != 0)
            {
                ans[1] ^= num;
            }
            else
            {
                ans[0] ^= num;
            }
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,1,3,2,5]\n
// @lcpr case=end

// @lcpr case=start
// [-1,0]\n
// @lcpr case=end

// @lcpr case=start
// [0,1]\n
// @lcpr case=end

 */

