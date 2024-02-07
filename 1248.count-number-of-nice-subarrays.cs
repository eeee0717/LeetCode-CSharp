/*
 * @lc app=leetcode.cn id=1248 lang=csharp
 * @lcpr version=30116
 *
 * [1248] 统计「优美子数组」
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int NumberOfSubarrays(int[] nums, int k)
    {
        int left = 0, right = 0, oddCnt = 0, res = 0;
        while (right < nums.Length)
        {
            if (nums[right++] % 2 == 1)
            {
                oddCnt++;
            }
            if (oddCnt == k)
            {
                var tmp = right;
                while (right < nums.Length && (nums[right] % 2 == 0))
                {
                    right++;
                }
                int leftCount = 0;
                while (nums[left] % 2 == 0)
                {
                    leftCount++;
                    left++;
                }
                int rightCount = right - tmp;
                res += (rightCount + 1) * (leftCount + 1);
                left++;
                oddCnt--;
            }
        }
        return res;

    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,1,2,1,1]\n3\n
// @lcpr case=end

// @lcpr case=start
// [2,4,6]\n1\n
// @lcpr case=end

// @lcpr case=start
// [2,2,2,1,2,2,1,2,2,2]\n2\n
// @lcpr case=end

 */

