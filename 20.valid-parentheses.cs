/*
 * @lc app=leetcode.cn id=20 lang=csharp
 * @lcpr version=30108
 *
 * [20] 有效的括号
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0) return false;
        Stack<char> st = new();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(') st.Push(')');
            else if (s[i] == '[') st.Push(']');
            else if (s[i] == '{') st.Push('}');
            else if (st.Count == 0 || st.Pop() != s[i])
                return false;
        }
        if(st.Count > 0) return false;
        return true;

    }
}
// @lc code=end



/*
// @lcpr case=start
// "()"\n
// @lcpr case=end

// @lcpr case=start
// "()[]{}"\n
// @lcpr case=end

// @lcpr case=start
// "(]"\n
// @lcpr case=end

 */

