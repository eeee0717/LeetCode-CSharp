/*
 * @lc app=leetcode.cn id=165 lang=csharp
 * @lcpr version=30202
 *
 * [165] 比较版本号
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution {
    public int CompareVersion(string version1, string version2) {
        int m = version1.Length; 
        int n = version2.Length;
        int index1 = 0, index2 = 0;
        while(index1 < m || index2 < n)
        {
            int reversion1 = 0, reversion2 = 0;
            while(index1 < m && version1[index1] != '.')
            {
                int digit = version1[index1] - '0';
                reversion1 = reversion1*10+digit;
                index1++;
            }
            index1++;
              while(index2 < n && version2[index2] != '.')
            {
                int digit = version2[index2] - '0';
                reversion2 = reversion2*10+digit;
                index2++;
            }
            index2++;
            if(reversion1 != reversion2)
            {
                return reversion1 < reversion2 ? -1 : 1;
            }
        }
        return 0;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "1.2"\n"1.10"\n
// @lcpr case=end

// @lcpr case=start
// "1.01"\n"1.001"\n
// @lcpr case=end

// @lcpr case=start
// "1.0"\n"1.0.0.0"\n
// @lcpr case=end

 */

