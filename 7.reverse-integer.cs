/*
 * @lc app=leetcode.cn id=7 lang=csharp
 * @lcpr version=30122
 *
 * [7] 整数反转
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int Reverse(int x)
    {
        int res = 0;
        while (x != 0)
        {
            int tmp = x % 10;
            if (res > 214748364 || (res == 214748364 && tmp > 7))
            {
                return 0;
            }
            if (res < -214748364 || (res == -214748364 && tmp < -8))
            {
                return 0;
            }
            res = res * 10 + tmp;
            x /= 10;
        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 123\n
// @lcpr case=end

// @lcpr case=start
// -123\n
// @lcpr case=end

// @lcpr case=start
// 120\n
// @lcpr case=end

// @lcpr case=start
// 0\n
// @lcpr case=end

 */

