/*
 * @lc app=leetcode.cn id=8 lang=csharp
 * @lcpr version=30122
 *
 * [8] 字符串转换整数 (atoi)
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MyAtoi(string s)
    {
        int res = 0, binary = int.MaxValue / 10;
        int i = 0, sign = 1, length = s.Length;
        if (length == 0) return 0;
        while (s[i] == ' ')
        {
            if (++i == length)
            {
                return 0;
            }
        }
        if (s[i] == '-') sign = -1;
        if (s[i] == '-' || s[i] == '+')
        {
            i++;
        }
        for (int j = i; j < length; j++)
        {
            if (s[j] < '0' || s[j] > '9') break;
            if (res > binary || (res == binary && s[j] > '7'))
            {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }
            res = res * 10 + s[j] - '0';
        }
        return sign * res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "42"\n
// @lcpr case=end

// @lcpr case=start
// "   -42"\n
// @lcpr case=end

// @lcpr case=start
// "4193 with words"\n
// @lcpr case=end

 */

