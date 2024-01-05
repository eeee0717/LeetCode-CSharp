/*
 * @lc app=leetcode.cn id=452 lang=csharp
 * @lcpr version=30112
 *
 * [452] 用最少数量的箭引爆气球
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int FindMinArrowShots(int[][] points)
    {
        if (points.Length == 0) return 0;
        Array.Sort(points, (a, b) => a[0].CompareTo(b[0]));
        int count = 1;
        for (int i = 1; i < points.Length; i++)
        {
            if (points[i][0] > points[i - 1][1]) count++;
            else points[i][1] = Math.Min(points[i][1], points[i - 1][1]);
        }
        return count;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[10,16],[2,8],[1,6],[7,12]]\n
// @lcpr case=end

// @lcpr case=start
// [[1,2],[3,4],[5,6],[7,8]]\n
// @lcpr case=end

// @lcpr case=start
// [[1,2],[2,3],[3,4],[4,5]]\n
// @lcpr case=end

 */

