/*
 * @lc app=leetcode.cn id=435 lang=csharp
 * @lcpr version=30113
 *
 * [435] 无重叠区间
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        if (intervals.Length == 0) return 0;
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));
        int res = 1, end = intervals[0][1];
        for (int i = 1; i < intervals.Length; i++)
        {
            if (end <= intervals[i][0])
            {
                end = intervals[i][1];
                res++;
            }
        }
        return intervals.Length - res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[1,2],[2,3],[3,4],[1,3]]\n
// @lcpr case=end

// @lcpr case=start
// [ [1,2], [1,2], [1,2] ]\n
// @lcpr case=end

// @lcpr case=start
// [ [1,2], [2,3] ]\n
// @lcpr case=end

 */

