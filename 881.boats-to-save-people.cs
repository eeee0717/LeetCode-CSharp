/*
 * @lc app=leetcode.cn id=881 lang=csharp
 * @lcpr version=30117
 *
 * [881] 救生艇
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int NumRescueBoats(int[] people, int limit)
    {
        Array.Sort(people);
        int l = 0, r = people.Length - 1;
        int res = 0;
        System.Console.WriteLine(people[0]);
        while (l <= r)
        {
            int sum = people[l] + people[r];
            if (sum > limit)
            {
                r--;
            }
            else
            {
                l++;
                r--;
            }
            res++;
        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2]\n3\n
// @lcpr case=end

// @lcpr case=start
// [3,2,2,1]\n3\n
// @lcpr case=end

// @lcpr case=start
// [3,5,3,4]\n5\n
// @lcpr case=end

 */

