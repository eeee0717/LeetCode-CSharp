/*
 * @lc app=leetcode.cn id=17 lang=csharp
 * @lcpr version=30111
 *
 * [17] 电话号码的字母组合
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public IList<string> res = new List<string>();
    public string s;
    public string[] letterMap = new string[10] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
    public IList<string> LetterCombinations(string digits)
    {
        if (digits.Length == 0)
            return res;
        BackTracking(digits, 0);
        return res;
    }
    public void BackTracking(string digits, int index)
    {
        if (index == digits.Length)
        {
            res.Add(s);
            return;
        }
        int digit = digits[index] - '0';
        string letters = letterMap[digit];
        for (int i = 0; i < letters.Length; i++)
        {
            s += letters[i];
            BackTracking(digits, index + 1);
            s = s.Substring(0, s.Length - 1);
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// "23"\n
// @lcpr case=end

// @lcpr case=start
// ""\n
// @lcpr case=end

// @lcpr case=start
// "2"\n
// @lcpr case=end

 */

