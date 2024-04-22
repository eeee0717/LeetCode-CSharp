/*
 * @lc app=leetcode.cn id=227 lang=csharp
 * @lcpr version=30122
 *
 * [227] 基本计算器 II
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int Calculate(string s)
    {
        s = s.Replace(" ", "");
        char[] s1 = s.ToCharArray();
        Stack ts = new Stack();
        int len = s1.Length;
        int ans = 0;
        int num = 0;
        char opt = '+';
        char ch;
        for (int i = 0; i < len; i++)
        {
            while (char.IsDigit(s1[i]))
            {
                num = num * 10 + s[i] - '0';
                i++;
                if (i >= len)
                {
                    i--;
                    break;
                }
            }
            ch = s1[i];
            switch (opt)
            {
                case '+':
                    ts.Push(num);
                    break;
                case '-':
                    ts.Push(-num);
                    break;
                case '*':
                    ts.Push((int)ts.Pop() * num);
                    break;
                case '/':
                    ts.Push((int)ts.Pop() / num);
                    break;
                default:
                    break;
            }
            num = 0;
            opt = ch;

        }
        while (ts.Count > 0)
        {
            ans += (int)ts.Pop();
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "3+2*2"\n
// @lcpr case=end

// @lcpr case=start
// " 3/2 "\n
// @lcpr case=end

// @lcpr case=start
// " 3+5 / 2 "\n
// @lcpr case=end

 */

