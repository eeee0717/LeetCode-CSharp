/*
 * @lc app=leetcode.cn id=739 lang=csharp
 * @lcpr version=30121
 *
 * [739] 每日温度
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] res = new int[n];
        var st = new Stack<int>();
        for(int i = 0; i < n; i++)
        {
            while(st.Count != 0 && temperatures[i] > temperatures[st.Peek()]){
                var tmp = st.Pop();
                res[tmp] = i - tmp;
            }

            st.Push(i);
        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [73,74,75,71,69,72,76,73]\n
// @lcpr case=end

// @lcpr case=start
// [30,40,50,60]\n
// @lcpr case=end

// @lcpr case=start
// [30,60,90]\n
// @lcpr case=end

 */

