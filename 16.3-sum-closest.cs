/*
 * @lc app=leetcode.cn id=16 lang=csharp
 * @lcpr version=30116
 *
 * [16] 最接近的三数之和
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);
        int res = 0, n = nums.Length;
        int minDiff = int.MaxValue;

        for (int i = 0; i < n - 2; i++)
        {
            int x = nums[i];
            if (i > 0 && x == nums[i - 1]) continue;

            int s = x + nums[i + 1] + nums[i + 2];
            if (s > target)
            {
                if (s - target < minDiff)
                {
                    res = s;
                }
                break;
            }

            s = x + nums[n - 1] + nums[n - 2];
            if (s < target)
            {
                if (target - s < minDiff)
                {
                    minDiff = target - s;
                    res = s;
                }
                continue;
            }

            int j = i + 1, k = n - 1;
            while (j < k)
            {
                s = x + nums[j] + nums[k];
                if(s == target) return target;
                if (s > target)
                {
                    if (s - target < minDiff)
                    {
                        minDiff = s - target;
                        res = s;
                    }
                    k--;
                }
                else
                {
                    if (target - s < minDiff)
                    {
                        minDiff = target - s;
                        res = s;
                    }
                    j++;
                }
            }
            
        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [-1,2,1,-4]\n1\n
// @lcpr case=end

// @lcpr case=start
// [0,0,0]\n1\n
// @lcpr case=end

 */

