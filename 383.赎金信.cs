/*
 * @lc app=leetcode.cn id=383 lang=csharp
 *
 * [383] 赎金信
 */

// @lc code=start
public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> map = new();
        foreach (var s in magazine)
        {
            if (map.ContainsKey(s))
                map[s]++;
            else
                map.Add(s, 1);
        }
        foreach (var t in ransomNote)
        {
            if (map.ContainsKey(t) && map[t] > 0)
                map[t]--;
            else
                return false;
        }
        return true;
    }
}
// @lc code=end

