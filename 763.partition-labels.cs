/*
 * @lc app=leetcode.cn id=763 lang=csharp
 * @lcpr version=30113
 *
 * [763] 划分字母区间
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public IList<int> PartitionLabels(string s)
    {
        int[] location = new int[27];
        for (int i = 0; i < s.Length; i++)
        {
            location[s[i] - 'a'] = i;
        }
        List<int> res = new List<int>();
        int left = 0, right = 0;
        for (int i = 0; i < s.Length; i++)
        {
            right = Math.Max(right, location[s[i] - 'a']);
            if (i == right)
            {
                res.Add(right - left + 1);
                left = i + 1;
            }
        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "ababcbacadefegdehijhklij"\n
// @lcpr case=end

// @lcpr case=start
// "eccbbbbdec"\n
// @lcpr case=end

 */

