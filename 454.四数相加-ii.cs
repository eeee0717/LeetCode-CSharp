/*
 * @lc app=leetcode.cn id=454 lang=csharp
 *
 * [454] 四数相加 II
 */

// @lc code=start
public class Solution
{
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
    {
        var map = new Dictionary<int, int>();
        var count = 0;
        foreach (var a in nums1)
        {
            foreach (var b in nums2)
            {
                if (map.ContainsKey(a + b))
                {
                    map[a + b]++;
                }
                else
                {
                    map.Add((a + b), 1);
                }

            }
        }
        foreach (var c in nums3)
        {
            foreach (var d in nums4)
            {
                int sum = c + d;
                if (map.TryGetValue(-sum, out var result))
                    count += result;
            }
        }
        return count;
    }
}
// @lc code=end

