/*
 * @lc app=leetcode.cn id=738 lang=csharp
 * @lcpr version=30113
 *
 * [738] 单调递增的数字
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MonotoneIncreasingDigits(int n)
    {
        char[] s = n.ToString().ToCharArray();
        int flag = s.Length;
        for (int i = s.Length - 1; i > 0; i--)
        {
            if (s[i - 1] > s[i])
            {
                flag = i;
                s[i - 1]--;
            }
        }
        for (int i = flag; i < s.Length; i++)
        {
            s[i] = '9';
        }
        return int.Parse(new string(s));
    }
}
// @lc code=end



/*
// @lcpr case=start
// 10\n
// @lcpr case=end

// @lcpr case=start
// 1234\n
// @lcpr case=end

// @lcpr case=start
// 332\n
// @lcpr case=end

 */

