/*
 * @lc app=leetcode.cn id=406 lang=csharp
 * @lcpr version=30112
 *
 * [406] 根据身高重建队列
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[][] ReconstructQueue(int[][] people)
    {
        Array.Sort(people, (a, b) =>
        {
            if (a[0] == b[0])
            {
                return a[1] - b[1];
            }
            return b[0] - a[0];
        });
        var res = new List<int[]>();
        for (int i = 0; i < people.Length; i++)
        {
            res.Insert(people[i][1], people[i]);
        }
        return res.ToArray();
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[7,0],[4,4],[7,1],[5,0],[6,1],[5,2]]\n
// @lcpr case=end

// @lcpr case=start
// [[6,0],[5,0],[4,0],[3,2],[2,2],[1,4]]\n
// @lcpr case=end

 */

