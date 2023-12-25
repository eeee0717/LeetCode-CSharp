/*
 * @lc app=leetcode.cn id=455 lang=csharp
 * @lcpr version=30112
 *
 * [455] 分发饼干
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);
        int index = s.Length - 1;
        int res = 0;
        for (int i = g.Length - 1; i >=0; i--)
        {
            if(index >=0 && s[index]>=g[i])
            {
                res++;
                index--;
            }
        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3]\n[1,1]\n
// @lcpr case=end

// @lcpr case=start
// [1,2]\n[1,2,3]\n
// @lcpr case=end

 */

