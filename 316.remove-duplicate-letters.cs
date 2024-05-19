/*
 * @lc app=leetcode.cn id=316 lang=csharp
 * @lcpr version=30202
 *
 * [316] 去除重复字母
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string RemoveDuplicateLetters(string s)
    {
        int[] lastIndices = new int[26];
        Array.Fill(lastIndices, -1);
        bool[] used = new bool[26];
        int length = s.Length;
        for (int i = 0; i < length; i++)
        {
            lastIndices[s[i] - 'a'] = i;
        }
        StringBuilder sb = new StringBuilder();
        int top = -1;
        for (int i = 0; i < length; i++)
        {
            char c = s[i];
            int letterIndex = c - 'a';
            if (!used[letterIndex])
            {
                while (sb.Length > 0 && sb[top] > c && lastIndices[sb[top] - 'a'] > i)
                {
                    used[sb[top] - 'a'] = false;
                    sb.Length = top;
                    top--;
                }
                used[letterIndex] = true;
                sb.Append(c);
                top++;
            }
        }
        return sb.ToString();

    }
}
// @lc code=end



/*
// @lcpr case=start
// "bcabc"\n
// @lcpr case=end

// @lcpr case=start
// "cbacdcbc"\n
// @lcpr case=end

 */

