/*
 * @lc app=leetcode.cn id=845 lang=csharp
 * @lcpr version=30116
 *
 * [845] 数组中的最长山脉
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int LongestMountain(int[] arr)
    {
        int n = arr.Length;
        int l = 0, p = 0, r = 0;
        int up = 1, res = 0;
        while (r <= n - 2)
        {
            if (arr[r] < arr[r + 1] && up == 1)
            {
                r++;
            }
            else if (arr[r] > arr[r + 1] && up == 1)
            {
                p = r;
                up = 0;
                r++;
            }
            else if (arr[r] > arr[r + 1] && up == 0)
            {
                r++;
            }
            else if (arr[r] < arr[r + 1] && up == 0)
            {
                if (l < p && p < r)
                {
                    res = Math.Max(r - l + 1, res);
                }
                l = r;
                p = r;
                r++;
                up = 1;
            }
            else if (arr[r] == arr[r + 1])
            {
                if (l < p && p < r)
                {
                    res = Math.Max(r - l + 1, res);
                }
                r++;
                l = r;
                p = r;
                up = 1;
            }

        }
        if (l < p && p < r)
        {
            res = Math.Max(r - l + 1, res);
        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,1,4,7,3,2,5]\n
// @lcpr case=end

// @lcpr case=start
// [2,2,2]\n
// @lcpr case=end

 */

