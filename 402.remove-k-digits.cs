/*
 * @lc app=leetcode.cn id=402 lang=csharp
 * @lcpr version=30122
 *
 * [402] 移掉 K 位数字
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution {
    public string RemoveKdigits(string num, int k) {
        if(num.Length == k) return "0";
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < num.Length; i++)
        {
            while (stack.Count > 0 && k > 0 && stack.Peek() > num[i])
            {
                stack.Pop();
                k--;
            }
            stack.Push(num[i]);
        }
        while (k > 0)
        {
            stack.Pop();
            k--;
        }
        StringBuilder sb = new StringBuilder();
        while (stack.Count > 0)
        {
            sb.Append(stack.Pop());
        }
        string res = sb.ToString();
        char[] resArr = res.ToCharArray();
        Array.Reverse(resArr);
        res = new string(resArr).TrimStart('0');
        return res == "" ? "0" : res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "1432219"\n3\n
// @lcpr case=end

// @lcpr case=start
// "10200"\n1\n
// @lcpr case=end

// @lcpr case=start
// "10"\n2\n
// @lcpr case=end

 */

