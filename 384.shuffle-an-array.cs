/*
 * @lc app=leetcode.cn id=384 lang=csharp
 * @lcpr version=30122
 *
 * [384] 打乱数组
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution {
    int len;
    int[] nums;
    int[] shuffled;
    Random random;

    public Solution(int[] nums) {
        this.len = nums.Length;
        this.nums = nums;
        this.shuffled = new int[len];
        Array.Copy(nums, 0, shuffled, 0 ,len);
        this.random = new Random();
    }
    
    public int[] Reset() {
        return this.nums;
    }
    
    public int[] Shuffle() {
        for(int i = 0, remain = len; i < len; i++, remain--)
        {
            int j = i + random.Next(remain);
            (shuffled[i], shuffled[j]) = (shuffled[j], shuffled[i]);
        }
        return shuffled;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */
// @lc code=end



