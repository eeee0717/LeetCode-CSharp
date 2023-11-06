/*
 * @lc app=leetcode.cn id=28 lang=csharp
 * @lcpr version=30105
 *
 * [28] 找出字符串中第一个匹配项的下标
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (string.IsNullOrEmpty(needle))
            return 0;

        if (needle.Length > haystack.Length || string.IsNullOrEmpty(haystack))
            return -1;

        return KMP(haystack, needle);
    }

    public int KMP(string haystack, string needle)
    {
        int[] next = GetNext(needle);
        int i = 0, j = 0;
        while (i < haystack.Length)
        {
            if (haystack[i] == needle[j])
            {
                i++;
                j++;
            }
            if (j == needle.Length)
                return i-j;
            else if (i < haystack.Length && haystack[i] != needle[j])
                if (j != 0)
                {
                    j = next[j - 1];
                }
                else
                {
                    i++;
                }
        }
        return -1;
    }

    public int[] GetNext(string needle)
    {
        int[] next = new int[needle.Length];
        next[0] = 0;
        int i = 1, j = 0;
        while (i < needle.Length)
        {
            if (needle[i] == needle[j])
            {
                next[i++] = ++j;
            }
            else
            {
                if (j == 0)
                {
                    next[i++] = 0;
                }
                else
                {
                    j = next[j - 1];
                }
            }
        }
        return next;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "sadbutsad"\n"sad"\n
// @lcpr case=end

// @lcpr case=start
// "leetcode"\n"leeto"\n
// @lcpr case=end

 */

