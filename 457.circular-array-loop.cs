/*
 * @lc app=leetcode.cn id=457 lang=csharp
 * @lcpr version=30117
 *
 * [457] 环形数组是否存在循环
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool CircularArrayLoop(int[] nums)
    {
        int n = nums.Length;
        if (n <= 1) return false;
        var visited = new bool[n];
        for (int i = 0; i < n; i++)
        {
            if (visited[i]) continue;
            bool positive = nums[i] > 0;
            int slow = i, fast = GetNext(nums, i);
            visited[slow] = true;
            //fast的正负号和head不符，说明遇到了链表尾部null
            while ((nums[fast] > 0) == positive && slow != fast)
            {
                slow = GetNext(nums, slow);
                visited[slow] = true;
                fast = GetNext(nums, fast);
                //fast的正负号和head不符，说明遇到了链表尾部null
                if ((nums[fast] > 0) != positive) break;
                fast = GetNext(nums, fast);
            }
            //fast不是尾部，此时fast和slow一定都在环内
            //长度大于1，需要判断fast（或slow）的next是否指向自己
            if ((nums[fast] > 0) == positive && fast != GetNext(nums, fast))
            {
                //Console.WriteLine($"{fast}");
                return true;
            }
        }
        return false;

    }
    public int GetNext(int[] nums, int idx)
    {
        int n = nums.Length;
        idx = (nums[idx] + idx) % n;
        if (idx < 0) idx += n;
        return idx;
    }

}
// @lc code=end



/*
// @lcpr case=start
// [2,-1,1,2,2]\n
// @lcpr case=end

// @lcpr case=start
// [-1,2]\n
// @lcpr case=end

// @lcpr case=start
// [-2,1,-1,-2,-2]\n
// @lcpr case=end

 */

