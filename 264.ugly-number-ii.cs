/*
 * @lc app=leetcode.cn id=264 lang=csharp
 * @lcpr version=30202
 *
 * [264] 丑数 II
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int NthUglyNumber(int n)
    {
        int a = 0, b = 0, c = 0;
        int[] res = new int[n];
        res[0] = 1;
        for (int i = 1; i < n; i++)
        {
            int n2 = res[a] * 2, n3 = res[b] * 3, n5 = res[c] * 5;
            res[i] = Math.Min(Math.Min(n2, n3), n5);
            if (res[i] == n2) a++;
            if (res[i] == n3) b++;
            if (res[i] == n5) c++;
        }
        return res[n - 1];
    }
}
// @lc code=end



/*
// @lcpr case=start
// 10\n
// @lcpr case=end

// @lcpr case=start
// 1\n
// @lcpr case=end

 */

