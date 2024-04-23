/*
 * @lc app=leetcode.cn id=50 lang=csharp
 * @lcpr version=30122
 *
 * [50] Pow(x, n)
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public double MyPow(double x, int n)
    {
        if (x == 0.0d) return 0.0d;
        long b = n;
        double res = 1.0;
        if (b < 0)
        {
            x = 1 / x;
            b = -b;
        }
        while (b > 0)
        {
            if (b % 2 == 1) res *= x;
            x *= x;
            b >>= 1;
        }
        return res;
    }

}
// @lc code=end



/*
// @lcpr case=start
// 2.00000\n10\n
// @lcpr case=end

// @lcpr case=start
// 2.10000\n3\n
// @lcpr case=end

// @lcpr case=start
// 2.00000\n-2\n
// @lcpr case=end

 */

