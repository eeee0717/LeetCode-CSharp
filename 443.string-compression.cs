/*
 * @lc app=leetcode.cn id=443 lang=csharp
 * @lcpr version=30202
 *
 * [443] 压缩字符串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int Compress(char[] chars)
    {
        int p = 0, q = 0, n = chars.Length;
        while (q < n)
        {
            var cur = chars[q];
            int cnt = 0;
            while(q < n && chars[q] == cur)
            {
                cnt++;
                q++;
            }
            chars[p++] =cur; // Convert cnt to char
            if(cnt!=1)
            {
                char[] counter = (cnt+"").ToCharArray();
                foreach(char c in counter)
                {
                    chars[p++] = c;
                }
            }

        }
        return p;
    }
}
// @lc code=end



/*
// @lcpr case=start
// ["a","a","b","b","c","c","c"]\n
// @lcpr case=end

// @lcpr case=start
// ["a"]\n
// @lcpr case=end

// @lcpr case=start
// ["a","b","b","b","b","b","b","b","b","b","b","b","b"]\n
// @lcpr case=end

 */

