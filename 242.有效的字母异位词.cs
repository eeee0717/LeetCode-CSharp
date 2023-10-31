/*
 * @lc app=leetcode.cn id=242 lang=csharp
 *
 * [242] 有效的字母异位词
 */

// @lc code=start
public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] record = new int[26];
        foreach (var item in s)
        {
            record[item - 'a']++;
        }
        foreach(var item in t){
            record[item - 'a']--;
        }
        for (int i = 0; i < 26; i++)
        {
            if(record[i] != 0) return false;
        }
        return true;
    }
}
// @lc code=end

