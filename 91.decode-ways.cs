/*
 * @lc app=leetcode.cn id=91 lang=csharp
 * @lcpr version=30122
 *
 * [91] 解码方法
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution {
    public int NumDecodings(string s) {
        int n = s.Length;
        int[] f = new int[3];
        s = " "+s;
        char[] cs = s.ToArray();
        f[0] = 1;
        for(int i = 1; i <= n;i++)
        {
            f[i%3] = 0;
            var a = cs[i] - '0';
            var b = (cs[i-1]-'0')*10+(cs[i] - '0');
            if(a>=1 && a <=9) f[i%3] = f[(i-1)%3];
            if(b>=10&&b<=26) f[i%3]+=f[(i-2)%3];
        }
        return f[n%3];
    }
}
// @lc code=end



/*
// @lcpr case=start
// "12"\n
// @lcpr case=end

// @lcpr case=start
// "226"\n
// @lcpr case=end

// @lcpr case=start
// "06"\n
// @lcpr case=end

 */

