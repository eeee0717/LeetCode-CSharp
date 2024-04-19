/*
 * @lc app=leetcode.cn id=1146 lang=csharp
 * @lcpr version=30122
 *
 * [1146] 快照数组
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class SnapshotArray
{
    int id = 0;
    IList<int[]>[] snapshots;

    public SnapshotArray(int length)
    {
        snapshots = new List<int[]>[length];
        for (int i = 0; i < length; i++)
        {
            snapshots[i] = new List<int[]>();
        }
    }

    public void Set(int index, int val)
    {
        snapshots[index].Add(new int[] { id, val });
    }

    public int Snap()
    {
        var curr = id;
        id++;
        return curr;
    }

    public int Get(int index, int snap_id)
    {
        IList<int[]> snaplist = snapshots[index];
        int low = -1, high = snaplist.Count - 1;
        while (low < high)
        {
            int mid = low + (high - low + 1) / 2;
            if (snaplist[mid][0] <= snap_id)
            {
                low = mid;
            }
            else
            {
                high = mid - 1;
            }
        }
        return low >= 0 ? snaplist[low][1] : 0;

    }
}

/**
 * Your SnapshotArray object will be instantiated and called as such:
 * SnapshotArray obj = new SnapshotArray(length);
 * obj.Set(index,val);
 * int param_2 = obj.Snap();
 * int param_3 = obj.Get(index,snap_id);
 */
// @lc code=end



/*
// @lcpr case=start
// ["SnapshotArray","set","snap","set","get"][[3],[0,5],[],[0,6],[0,0]]\n
// @lcpr case=end

 */

