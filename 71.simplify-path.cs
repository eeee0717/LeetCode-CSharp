/*
 * @lc app=leetcode.cn id=71 lang=csharp
 * @lcpr version=30122
 *
 * [71] 简化路径
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string SimplifyPath(string path)
    {
        Stack<string> st = new Stack<string>();
        var stringArray =path.Split('/');
        foreach (string item in stringArray)
        {
            if (item == "..")
            {
                if (st.Count > 0)
                {
                    st.Pop();
                }
            }
            else if(!string.IsNullOrEmpty(item) && item!=".")
            {
                st.Push(item);
            }
        }
        string res = "";
        foreach(string s in st)
        {
            res = "/"+s+res;
        }
        return string.IsNullOrEmpty(res) ? "/" : res;

    }
}
// @lc code=end



/*
// @lcpr case=start
// "/home/"\n
// @lcpr case=end

// @lcpr case=start
// "/../"\n
// @lcpr case=end

// @lcpr case=start
// "/home//foo/"\n
// @lcpr case=end

// @lcpr case=start
// "/a/./b/../../c/"\n
// @lcpr case=end

 */

