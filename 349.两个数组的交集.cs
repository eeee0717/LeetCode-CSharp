/*
 * @lc app=leetcode.cn id=349 lang=csharp
 *
 * [349] 两个数组的交集
 */

// @lc code=start
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        return nums1.Intersect(nums2).ToArray();
    }
}
// @lc code=end

