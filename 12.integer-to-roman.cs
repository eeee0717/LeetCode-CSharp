/*
 * @lc app=leetcode.cn id=12 lang=csharp
 * @lcpr version=30122
 *
 * [12] 整数转罗马数字
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    static int[] VALUES = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
    static String[] SYMBOLS = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };



    public string IntToRoman(int num)
    {
        StringBuilder sb = new StringBuilder();
        int length = 13;
        for (int i = 0; i < length; i++)
        {
            int value = VALUES[i];
            string symbol = SYMBOLS[i];
            int count = num / value;
            for (int j = 0; j < count; j++)
            {
                sb.Append(symbol);
            }
            num %= value;
        }
        return sb.ToString();
    }
}
// @lc code=end



/*
// @lcpr case=start
// 3\n
// @lcpr case=end

// @lcpr case=start
// 4\n
// @lcpr case=end

// @lcpr case=start
// 9\n
// @lcpr case=end

// @lcpr case=start
// 58\n
// @lcpr case=end

// @lcpr case=start
// 1994\n
// @lcpr case=end

 */

