/*
 * @lc app=leetcode.cn id=345 lang=csharp
 * @lcpr version=30117
 *
 * [345] 反转字符串中的元音字母
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string ReverseVowels(string s)
    {
        int l = 0, r = s.Length - 1;
        var arr = s.ToCharArray();
        var alpha = "aeiouAEIOU";
        while (l < r)
        {
            if (alpha.Contains(arr[l]) && !alpha.Contains(arr[r]))
            {
                r--;
            }
            else if (!alpha.Contains(arr[l]) && alpha.Contains(arr[r]))
            {
                l++;
            }
            else if(!alpha.Contains(arr[l]) && !alpha.Contains(arr[r]))
            {
                l++;
                r--;
            }
            else
            {
                (arr[l], arr[r]) = (arr[r], arr[l]);
                l++;
                r--;
            }
        }
        return new string(arr);
    }
}
// @lc code=end



/*
// @lcpr case=start
// "hello"\n
// @lcpr case=end

// @lcpr case=start
// "leetcode"\n
// @lcpr case=end

 */

