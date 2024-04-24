/*
 * @lc app=leetcode.cn id=718 lang=csharp
 * @lcpr version=30122
 *
 * [718] 最长重复子数组
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int FindLength(int[] nums1, int[] nums2)
    {
        int m = nums1.Length;
        int n = nums2.Length;
        int res = 0, count = 0;
        for (int i = 0; i <= m + n - 1; i++)
        {
            count = 0;
            for (int j = 0; j < i; j++)
            {
                if (j >= m || n - i + j < 0)
                {
                    continue;
                }
                if (nums1[j] == nums2[n - i + j])
                {
                    count++;
                    res = Math.Max(res, count);
                }
                else
                {
                    count = 0;
                }

            }
        }
        return res;
    }

}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,2,1]\n[3,2,1,4,7]\n
// @lcpr case=end

// @lcpr case=start
// [0,0,0,0,0]\n[0,0,0,0,0]\n
// @lcpr case=end

 */

