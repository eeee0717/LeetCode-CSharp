/*
 * @lc app=leetcode.cn id=15 lang=csharp
 *
 * [15] 三数之和
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var res = new List<IList<int>>();
        Array.Sort(nums);
        for(int i = 0; i < nums.Length - 2; i++)
        {
            int n1 = nums[i];
            if(n1 > 0)
                break;
            if(i > 0 && n1 == nums[i - 1])
                continue;
            int left = i + 1;
            int right = nums.Length - 1;
            while(left < right)
            {
                int n2 = nums[left];
                int n3 = nums[right];
                int sum = n1 + n2 + n3;
                if(sum > 0)
                {
                    right--;
                }
                else if(sum < 0)
                {
                    left++;
                }
                else
                {
                    res.Add(new List<int> {n1, n2, n3});
                    while(left < right && nums[left] == n2)
                    {
                        left++;
                    }   
                     while(left < right && nums[right] == n3)
                    {
                        right--;
                    }  
                }
                                
            }

        }
        return res;

    }
}
// @lc code=end

