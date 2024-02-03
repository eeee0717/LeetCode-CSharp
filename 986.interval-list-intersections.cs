/*
 * @lc app=leetcode.cn id=986 lang=csharp
 * @lcpr version=30114
 *
 * [986] 区间列表的交集
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
    {
        IList<int[]> res = new List<int[]>();
        int length1 = firstList.Length, length2 = secondList.Length;
        int index1 = 0, index2 = 0;
        while (index1 < length1 && index2 < length2)
        {
            int[] interval1 = firstList[index1];
            int[] interval2 = secondList[index2];
            int start = Math.Max(interval1[0], interval2[0]);
            int end = Math.Min(interval1[1], interval2[1]);
            if (start <= end)
            {
                res.Add(new int[] { start, end });
            }
            if (interval1[1] <= interval2[1])
            {
                index1++;
            }
            else
            {
                index2++;
            }
        }
        return res.ToArray();

    }
}
// @lc code=end



/*
// @lcpr case=start
// [[0,2],[5,10],[13,23],[24,25]]\n[[1,5],[8,12],[15,24],[25,26]]\n
// @lcpr case=end

// @lcpr case=start
// [[1,3],[5,9]]\n[]\n
// @lcpr case=end

// @lcpr case=start
// []\n[[4,8],[10,12]]\n
// @lcpr case=end

// @lcpr case=start
// [[1,7]]\n[[3,10]]\n
// @lcpr case=end

 */

