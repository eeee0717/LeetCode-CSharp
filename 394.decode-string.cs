/*
 * @lc app=leetcode.cn id=394 lang=csharp
 * @lcpr version=30121
 *
 * [394] 字符串解码
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution {
    int index = 0;

    public string DecodeString(string s) {
        return Recurse(s).ToString();
    }

    public StringBuilder Recurse(String s) {
        StringBuilder sb = new StringBuilder();
        int length = s.Length;
        while (index < length) {
            char c = s[index];
            if (c == ']') {
                return sb;
            } else if (char.IsDigit(c)) {
                int num = 0;
                while (index < length && char.IsDigit(s[index])) {
                    num = num * 10 + s[index] - '0';
                    index++;
                }
                index++;
                StringBuilder temp = Recurse(s);
                for (int i = 0; i < num; i++) {
                    sb.Append(temp);
                }
            } else {
                sb.Append(c);
            }
            index++;
        }
        return sb;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "3[a]2[bc]"\n
// @lcpr case=end

// @lcpr case=start
// "3[a2[c]]"\n
// @lcpr case=end

// @lcpr case=start
// "2[abc]3[cd]ef"\n
// @lcpr case=end

// @lcpr case=start
// "abc3[cd]xyz"\n
// @lcpr case=end

 */

