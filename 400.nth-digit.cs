/*
 * @lc app=leetcode.cn id=400 lang=csharp
 * @lcpr version=30122
 *
 * [400] 第 N 位数字
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int FindNthDigit(int n)
    {
        int d = 1, count = 9;
        while (n > (long)d * count)
        {
            n -= d * count;
            d++;
            count *= 10;
        }
        int index = n - 1;
        int start = (int)Math.Pow(10, d - 1);
        int num = start + index / d;
        int digitIndex = index % d;
        int digit = (num / (int)(Math.Pow(10, d - digitIndex - 1))) % 10;
        return digit;


    }
}
// @lc code=end



/*
// @lcpr case=start
// 3\n
// @lcpr case=end

// @lcpr case=start
// 11\n
// @lcpr case=end

 */

