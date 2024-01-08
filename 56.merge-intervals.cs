/*
 * @lc app=leetcode.cn id=56 lang=csharp
 * @lcpr version=30113
 *
 * [56] 合并区间
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Length == 0)
            return intervals;
        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        List<List<int>> res = new List<List<int>>();
        res.Add(intervals[0].ToList());
        for (int i = 1; i < intervals.Length; i++)
        {
            if (res[res.Count - 1][1] >= intervals[i][0])
            {
                res[res.Count - 1][1] = Math.Max(res[res.Count - 1][1], intervals[i][1]);
            }
            else
            {
                res.Add(intervals[i].ToList());
            }
        }
        return res.Select(x => x.ToArray()).ToArray();
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[1,3],[2,6],[8,10],[15,18]]\n
// @lcpr case=end

// @lcpr case=start
// [[1,4],[4,5]]\n
// @lcpr case=end

 */

