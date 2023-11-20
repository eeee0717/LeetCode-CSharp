/*
 * @lc app=leetcode.cn id=257 lang=csharp
 * @lcpr version=30110
 *
 * [257] 二叉树的所有路径
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        List<int> path = new();
        List<string> res = new();
        if (root == null) return res;
        Traversal(root, path, res);
        return res;
    }
    public void Traversal(TreeNode node, List<int> path, List<string> res)
    {
        path.Add(node.val);
        if (node.left == null && node.right == null)
        {
            string sPath = "";
            for (int i = 0; i < path.Count - 1; i++)
            {
                sPath += path[i].ToString();
                sPath += "->";
            }
            sPath += path[path.Count - 1].ToString();
            res.Add(sPath);
            return;
        }
        if (node.left != null)
        {
            Traversal(node.left, path, res);
            path.RemoveAt(path.Count-1);
        }
        if (node.right != null)
        {
            Traversal(node.right, path, res);
            path.RemoveAt(path.Count-1);
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,null,5]\n
// @lcpr case=end

// @lcpr case=start
// [1]\n
// @lcpr case=end

 */

