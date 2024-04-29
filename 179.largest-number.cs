/*
 * @lc app=leetcode.cn id=179 lang=csharp
 * @lcpr version=30122
 *
 * [179] 最大数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string LargestNumber(int[] nums)
    {
        string[] res = new string[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            res[i] = "" + nums[i];
        }
        Array.Sort(res, (a, b) =>
        {
            string sa = a + b, sb = b + a;
            return sb.CompareTo(sa);
        });
        StringBuilder sb = new StringBuilder();
        foreach (var s in res)
        {
            sb.Append(s);
        }
        int len = sb.Length;
        int k = 0;
        while (k < len - 1 && sb[k] == '0') k++;
        return sb.ToString(k, len - k);

    }
}
// @lc code=end



/*
// @lcpr case=start
// [10,2]\n
// @lcpr case=end

// @lcpr case=start
// [3,30,34,5,9]\n
// @lcpr case=end

 */

