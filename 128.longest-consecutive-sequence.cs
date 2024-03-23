/*
 * @lc app=leetcode.cn id=128 lang=csharp
 * @lcpr version=30119
 *
 * [128] 最长连续序列
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution {
    public int LongestConsecutive(int[] nums) {
        int len = nums.Length;
        if(len == 0) return 0;
        var ht = new Hashtable();
        for(int i = 0; i < len; i++)
        {
            if(!ht.ContainsKey(nums[i]))
            {
                ht.Add(nums[i],null);
            }
        }
        int longestLength=0;
        foreach(int num in ht.Keys)
        {
            if(ht.ContainsKey(num - 1))
                continue;
            
            int curNum = num;
            int curLen = 0;
            while(ht.ContainsKey(curNum++))
                curLen++;
            longestLength = Math.Max(curLen, longestLength);
        }
        return longestLength;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [100,4,200,1,3,2]\n
// @lcpr case=end

// @lcpr case=start
// [0,3,7,2,5,8,4,6,0,1]\n
// @lcpr case=end

 */

