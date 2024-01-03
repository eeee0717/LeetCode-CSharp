/*
 * @lc app=leetcode.cn id=860 lang=csharp
 * @lcpr version=30112
 *
 * [860] 柠檬水找零
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool LemonadeChange(int[] bills)
    {
        int five = 0, ten = 0, twenty = 0;
        foreach (var bill in bills)
        {
            if (bill == 5)
            {
                five++;
            }
            if (bill == 10)
            {
                if (five == 0) return false;
                five--;
                ten++;
            }
            
            if (bill == 20)
            {
                if (ten > 0 && five > 0)
                {
                    ten--;
                    five--;
                    twenty++;
                }
                else if (five >= 3)
                {
                    five -= 3;
                    twenty++;
                }
                else
                {
                    return false;
                }

            }
        }
        return true;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [5,5,5,10,20]\n
// @lcpr case=end

// @lcpr case=start
// [5,5,10,10,20]\n
// @lcpr case=end

 */

