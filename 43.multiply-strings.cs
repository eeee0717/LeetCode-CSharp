/*
 * @lc app=leetcode.cn id=43 lang=csharp
 * @lcpr version=30122
 *
 * [43] 字符串相乘
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string Multiply(string num1, string num2)
    {
        if (num1.Equals("0") || num2.Equals("0")) return "0";
        int[] res = new int[num1.Length + num2.Length];
        for (int i = num1.Length - 1; i >= 0; i--)
        {
            int n1 = num1[i] - '0';
            for (int j = num2.Length - 1; j >= 0; j--)
            {
                int n2 = num2[j] - '0';
                int sum = (res[i + j + 1] + n1 * n2);
                res[i + j + 1] = sum % 10;
                res[i + j] += sum / 10;
            }
        }
        var result = new List<char>();
        for (int i = 0; i < res.Length; i++)
        {
            if (i == 0 && res[i] == 0) continue;
            result.Add((char)(res[i]+'0'));
        }
        return new string(result.ToArray());

    }

}
// @lc code=end



/*
// @lcpr case=start
// "2"\n"3"\n
// @lcpr case=end

// @lcpr case=start
// "123"\n"456"\n
// @lcpr case=end

 */

