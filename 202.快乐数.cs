/*
 * @lc app=leetcode.cn id=202 lang=csharp
 *
 * [202] 快乐数
 */

// @lc code=start
public class Solution
{
    public bool IsHappy(int n)
    {
        var sum = 0;
        var set = new HashSet<int>();
        while (sum != 1)
        {
            sum = 0;
            while(n>0){
                sum += (int)Math.Pow(n%10,2);
                n/=10;
            }
            if(set.Contains(sum)){
                return false;
            }
            set.Add(sum);
            n = sum;
        }
        return true;
    }
}
// @lc code=end

