/*
 * @lc app=leetcode.cn id=415 lang=csharp
 * @lcpr version=30122
 *
 * [415] 字符串相加
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string AddStrings(string num1, string num2)
    {
        StringBuilder sb = new StringBuilder();
        int i = num1.Length - 1, j = num2.Length - 1, carry = 0;
        while (i >= 0 || j >= 0 || carry != 0)
        {
            int n1 = i >= 0 ? num1[i] - '0' :
            0;
            int n2 = j >= 0 ? num2[j] - '0' :
           0;
            int tmp = n1 + n2 + carry;
            carry = tmp / 10;
            sb.Append(tmp % 10);
            i--; j--;
        }
        var charArray = sb.ToString().ToCharArray();
        Array.Reverse(charArray);

        return new string(charArray);


    }
}
// @lc code=end



/*
// @lcpr case=start
// "11"\n"123"\n
// @lcpr case=end

// @lcpr case=start
// "456"\n"77"\n
// @lcpr case=end

// @lcpr case=start
// "0"\n"0"\n
// @lcpr case=end

 */

