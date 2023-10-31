/*
 * @lc app=leetcode.cn id=69 lang=csharp
 *
 * [69] x 的平方根 
 */

// @lc code=start
public class Solution
{
    public int MySqrt(int x)
    {
        if(x==1) return 1;
        int l = 2;
        int r = x / 2;
        while (l <= r)
        {
            int mid = (l + r) / 2;
            if ((long)mid * mid == x)
                return mid;
            else if ((long)mid * mid > x)
                r = mid - 1;
            else
                l = mid + 1;
        }
        return r;
    }
}
// @lc code=end

