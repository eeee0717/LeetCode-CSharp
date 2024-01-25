/*
 * @lc app=leetcode.cn id=2859 lang=csharp
 * @lcpr version=30113
 *
 * [2859] 计算 K 置位下标对应元素的和
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int SumIndicesWithKSetBits(IList<int> nums, int k)
    {
        int res = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            if(BitCount(i) == k)
            {
                res += nums[i];
            }
        }
        return res;
    }
    public int BitCount(int n)
    {
        int res = 0;
        while (n > 0)
        {
            res += n & 1;
            n >>= 1;
        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [5,10,1,5,2]\n1\n
// @lcpr case=end

// @lcpr case=start
// [4,3,2,1]\n2\n
// @lcpr case=end

 */

