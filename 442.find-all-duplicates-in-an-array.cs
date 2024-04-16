/*
 * @lc app=leetcode.cn id=442 lang=csharp
 * @lcpr version=30122
 *
 * [442] 数组中重复的数据
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {
        IList<int> res = new List<int>();
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            int num = nums[i];
            int index = Math.Abs(num) - 1;
            if (nums[index] > 0)
            {
                nums[index] *= -1;
            }
            else
            {
                res.Add(index + 1);
            }
        }
        return res;
    }

}
// @lc code=end



/*
// @lcpr case=start
// [4,3,2,7,8,2,3,1]\n
// @lcpr case=end

// @lcpr case=start
// [1,1,2]\n
// @lcpr case=end

// @lcpr case=start
// [1]\n
// @lcpr case=end

 */

