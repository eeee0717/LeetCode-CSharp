/*
 * @lc app=leetcode.cn id=167 lang=csharp
 * @lcpr version=30116
 *
 * [167] 两数之和 II - 输入有序数组
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        for (int l = 0; l < numbers.Length; l++)
        {
            int r = l + 1;
            while (r < numbers.Length)
            {
                if (numbers[l] + numbers[r] == target)
                    return new int[] { l+1, r+1 };
                else if (numbers[l] + numbers[r] < target)
                    r++;
                else
                    break;
            }
        }
        return new int[] { -1, -1 };
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,7,11,15]\n9\n
// @lcpr case=end

// @lcpr case=start
// [2,3,4]\n6\n
// @lcpr case=end

// @lcpr case=start
// [-1,0]\n-1\n
// @lcpr case=end

 */

