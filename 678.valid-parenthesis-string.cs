/*
 * @lc app=leetcode.cn id=678 lang=csharp
 * @lcpr version=30122
 *
 * [678] 有效的括号字符串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution {
    public bool CheckValidString(string s) {
        int l = 0, r = 0;
        foreach(var c in s.ToCharArray())
        {
            if(c == '(')
            {
                l++;
                r++;
            }
            else if(c == ')')
            {
                l--;
                r--;
            }
            else{
                l--;
                r++;
            }
            l = Math.Max(l, 0);
            if(l > r) return false;
        }
        return l==0;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "()"\n
// @lcpr case=end

// @lcpr case=start
// "(*)"\n
// @lcpr case=end

// @lcpr case=start
// "(*))"\n
// @lcpr case=end

 */

